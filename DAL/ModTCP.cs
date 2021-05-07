using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class ModTCP
    {
        //创建Socket对象
        Socket tcpclient;
        /// <summary>
        /// 建立MODBUS TCP连接
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        public bool Connect(string ip,string port)
        {
            //创建IPEndPoint对象
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(port));
            //Socket对象实例化
            tcpclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //建立Socket连接
            try
            {
                tcpclient.Connect(ie);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void DisConnect()
        {
            if(tcpclient!=null&&tcpclient.Connected)
            {
                tcpclient.Shutdown(SocketShutdown.Both);
                Thread.Sleep(100);
                tcpclient.Close();
            }
        }

        #region 读取保持型寄存器（功能码0x03）
        /// <summary>
        /// 读取保持型寄存器（功能码0x03）
        /// </summary>
        /// <param name="iAddress"></param>
        /// <param name="iLength"></param>
        /// <returns></returns>
        public byte[] ReadKeepReg(int iAddress,int iLength)
        {
            byte[] Result = null;
            //(1)组织报文
            ByteArray byteArray = new ByteArray();
            //前8个字节
            byteArray.Add(new byte[]
            {
                0,0,0,0,0,6,1,3
            });
            //第9/10字节
            byteArray.Add((byte)((iAddress - iAddress % 256)/256));
            byteArray.Add((byte)(iAddress % 256));
            //第11/12字节
            byteArray.Add((byte)((iLength - iLength % 256) / 256));
            byteArray.Add((byte)(iLength % 256));
            //(2)发送报文
            tcpclient.Send(byteArray.Array, byteArray.Array.Length, SocketFlags.None);
            //(3)接收报文
            byte[] data = new byte[512];
            tcpclient.Receive(data, 512, SocketFlags.None);
            //(4)判断报文
            if(data[8]==iLength*2)
            {
                //(5)解析报文
                Result = ByteMsgToRes(data, 9, iLength * 2);
            }
            return Result;
        }
        #endregion


        #region 预置浮点型保持型寄存器
        /// <summary>
        /// 预置浮点型保持型寄存器
        /// </summary>
        /// <param name="iAddress"></param>
        /// <param name="SetValue"></param>
        /// <returns></returns>
        public bool PreSetFloatReg(int iAddress,float SetValue)
        {
            byte[] Result = null;
            //(1)组织报文
            ByteArray byteArray = new ByteArray();
            //前8个字节
            byteArray.Add(new byte[]
            {
                0,0,0,0,0,11,1,16
            });
            //第9/10字节
            byteArray.Add((byte)((iAddress - iAddress % 256) / 256));
            byteArray.Add((byte)(iAddress % 256));
            //第11/12字节
            byteArray.Add(0);
            byteArray.Add(2);
            //第13字节
            byteArray.Add(4);
            //第14-17字节
            byte[] bSetValue = BitConverter.GetBytes(SetValue);
            if(bSetValue.Length==4)
            {
                byteArray.Add(bSetValue[3]);
                byteArray.Add(bSetValue[2]);
                byteArray.Add(bSetValue[1]);
                byteArray.Add(bSetValue[0]);
            }
            //(2)发送报文
            tcpclient.Send(byteArray.Array, byteArray.Array.Length, SocketFlags.None);
            //(3)接收报文
            byte[] data = new byte[512];
            tcpclient.Receive(data, 512, SocketFlags.None);
            //(4)解析报文
            Result = ByteMsgToRes(data, 0, 12);
            byte[] sendByteArray = ByteMsgToRes(byteArray.Array, 0, 12);
            sendByteArray[5] = 6;
            //(5)判断报文
            if(CompareByteArray(Result,sendByteArray))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        /// <summary>
        /// 比较两个数组是否完全相同
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        private bool CompareByteArray(byte[] b1,byte[] b2)
        {
            int length1 = b1.Length;
            int length2 = b2.Length;
            if(length1!=length2)
            {
                return false;
            }
            for (int i = 0; i < length1; i++)
            {
                if (b1[i] !=b2[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 从字节数组中截取数据
        /// </summary>
        /// <param name="MsgByte"></param>
        /// <param name="Start"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        private byte[] ByteMsgToRes(byte[] MsgByte,int Start,int Length)
        {
            byte[] Result = new byte[Length];
            if(MsgByte!=null&&MsgByte.Length>0)
            {
                for (int i = 0; i < Length; i++)
                {
                    Result[i] = MsgByte[i + Start];
                }
            }
            return Result;
        }
    }
}
