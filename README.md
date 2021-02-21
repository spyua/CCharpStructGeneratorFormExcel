# CCharpStructGeneratorFormTool

This tool can generate struct class, dll file, sql code from excel file.It also can connect the mssql server to generate poco class.

If you process the socket communcation with message stuct definition. It can help you to handle the system message definition in your code. You just maintain the excel file.

![image](https://user-images.githubusercontent.com/20264622/108627826-7b714480-7492-11eb-850c-baf7cab86955.png)

## Usage
 - Define your message column on Excel
 - Set the parameter on form
  - Source Path:Read excel path
  - Export Path: Cs target path
  - OutFileName: Cs file name
  - StarSheet:The read of star excel page
  - StarRow:The read of star row
  - StarColumn:The read of star column
 - Select the export format
 - <span style="color:red">Set DB Connection message in app.config</span>.

## Usage SOP  

![image](https://user-images.githubusercontent.com/20264622/108627922-e3278f80-7492-11eb-9d92-42b0bf3623e9.png)
 
## Excel Message Format
![image](https://user-images.githubusercontent.com/20264622/107941514-c5ef4e80-6fc4-11eb-8ccb-5e68f10017ac.png)

## Export Fomat Result

### Struct File

```
using System;
using System.Runtime.InteropServices;
namespace MsgStruct
{
    public class Msg_Demo
    {
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public class Msg_MsgA
        {
            [MarshalAs(UnmanagedType.I2)]
            public short MessageLength;
            [MarshalAs(UnmanagedType.I2)]
            public short MessageId;
            [MarshalAs(UnmanagedType.I4)]
            public int Date;
            [MarshalAs(UnmanagedType.I4)]
            public int Time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public byte[] ID;
            [MarshalAs(UnmanagedType.I4)]
            public int Mode;
            [MarshalAs(UnmanagedType.R4)]
            public float Length;

        }
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public class Msg_MsgB
        {
            [MarshalAs(UnmanagedType.I2)]
            public short MessageLength;
            [MarshalAs(UnmanagedType.I2)]
            public short MessageId;
            [MarshalAs(UnmanagedType.I4)]
            public int Date;
            [MarshalAs(UnmanagedType.I4)]
            public int Time;
            [MarshalAs(UnmanagedType.I4)]
            public int Spare1;
            [MarshalAs(UnmanagedType.I4)]
            public int Spare2;
            [MarshalAs(UnmanagedType.I4)]
            public int Spare3;
            [MarshalAs(UnmanagedType.I4)]
            public int Spare4;
            [MarshalAs(UnmanagedType.I4)]
            public int Spare5;

        }
        [Serializable]
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public class Msg_MsgC
        {
            [MarshalAs(UnmanagedType.I2)]
            public short MessageLength;
            [MarshalAs(UnmanagedType.I2)]
            public short MessageId;
            [MarshalAs(UnmanagedType.I4)]
            public int Date;
            [MarshalAs(UnmanagedType.I4)]
            public int Time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public byte[] ID;
            [MarshalAs(UnmanagedType.I4)]
            public int Spare1;
            [MarshalAs(UnmanagedType.I4)]
            public int Spare2;
            [MarshalAs(UnmanagedType.I4)]
            public int Spare3;
            [MarshalAs(UnmanagedType.I4)]
            public int Spare4;
            [MarshalAs(UnmanagedType.I4)]
            public int Spare5;

        }

    }
}
```

### Sql Code (Sql Table File)
```
Drop Table TBL_MsgA ;Create Table TBL_MsgA (
    MessageLength smallint ,
    MessageId smallint ,
    Date int ,
    Time int ,
    ID varchar (24) ,
    Mode int ,
    Length float ,
    CreateTime datetime ,
);
Drop Table TBL_MsgB ;Create Table TBL_MsgB (
    MessageLength smallint ,
    MessageId smallint ,
    Date int ,
    Time int ,
    Spare1 int ,
    Spare2 int ,
    Spare3 int ,
    Spare4 int ,
    Spare5 int ,
    CreateTime datetime ,
);
Drop Table TBL_MsgC ;Create Table TBL_MsgC (
    MessageLength smallint ,
    MessageId smallint ,
    Date int ,
    Time int ,
    ID varchar (24) ,
    Spare1 int ,
    Spare2 int ,
    Spare3 int ,
    Spare4 int ,
    Spare5 int ,
    CreateTime datetime ,
);

```
## DB poco class
```
namespace Models { 

	public class TBL_MsgA
	{
		public short MessageLength { get; set; }
		public short MessageId { get; set; }
		public int Date { get; set; }
		public int Time { get; set; }
		public string ID { get; set; }
		public int Mode { get; set; }
		public double Length { get; set; }
		public System.DateTime CreateTime { get; set; }
	}

	public class TBL_MsgB
	{
		public short MessageLength { get; set; }
		public short MessageId { get; set; }
		public int Date { get; set; }
		public int Time { get; set; }
		public int Spare1 { get; set; }
		public int Spare2 { get; set; }
		public int Spare3 { get; set; }
		public int Spare4 { get; set; }
		public int Spare5 { get; set; }
		public System.DateTime CreateTime { get; set; }
	}

	public class TBL_MsgC
	{
		public short MessageLength { get; set; }
		public short MessageId { get; set; }
		public int Date { get; set; }
		public int Time { get; set; }
		public string ID { get; set; }
		public int Spare1 { get; set; }
		public int Spare2 { get; set; }
		public int Spare3 { get; set; }
		public int Spare4 { get; set; }
		public int Spare5 { get; set; }
		public System.DateTime CreateTime { get; set; }
	}

}

```
