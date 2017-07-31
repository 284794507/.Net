using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tCTUInfo
    {
        public string CTUID { get; set; } // char(40), not null

        public string CTUName { get; set; } // nvarchar(40), not null

        public byte CTUType { get; set; } // tinyint, not null

        public byte CTUChNum { get; set; } // tinyint, not null

        public string CTUChByte { get; set; } // char(8), not null

        public byte? CtrlCloseDiv { get; set; } // tinyint, null

        public string CTUCommAddr { get; set; } // char(32), not null

        public string MobilePhoneNo { get; set; } // char(26), null

        public string SvrDomainIp { get; set; } // char(50), not null

        public int SvrPort { get; set; } // int, not null

        public string SvrAPN { get; set; } // char(32), null

        public int FSM { get; set; } // int, not null

        public byte HavePTUStatus { get; set; } // tinyint, not null

        public byte? DiAlarmTick { get; set; } // tinyint, null

        public byte? PollingTick { get; set; } // tinyint, null

        public byte? FindPTUTick { get; set; } // tinyint, null

        public int? PTUCount { get; set; } // int, null

        public string IPAddress { get; set; } // char(30), null

        public string MASKAddress { get; set; } // char(30), not null

        public string IPGateway { get; set; } // char(30), null

        public string CTUMacAddr { get; set; } // char(40), null

        public byte? DeviceType { get; set; } // tinyint, null

        public byte EnergyEfficient { get; set; } // tinyint, not null

        public int LogPrintTick { get; set; } // int, not null

        public byte PLCComTimer { get; set; } // tinyint, not null

        public byte EnergyTimeType { get; set; } // tinyint, not null

        public byte AutoRouteTick { get; set; } // tinyint, not null

        public string GSM_IMEI { get; set; } // char(30), null

        public string SIM_IMSI { get; set; } // char(30), null

        public byte? HaveRTU { get; set; } // tinyint, null

        public byte? NetworkType { get; set; } // tinyint, null

        public byte? DiUpdateTime { get; set; } // tinyint, null

        public string WeekCtlMark { get; set; } // char(8), null

        public string TempCtlMark { get; set; } // char(8), null

        public string SpecialDayCtlMark { get; set; } // char(8), null

        public byte? EveryDayCtlMark { get; set; } // tinyint, null

        public byte? PTUType { get; set; } // tinyint, null

        public string memo { get; set; } // nvarchar(200), null

        public int? GPRSTimeOut { get; set; } // int, null

        public byte? GPRSRetryCount { get; set; } // tinyint, null

        public byte? IsNeedRpyMask { get; set; } // tinyint, null

        public byte? GPRSHeart { get; set; } // tinyint, null

        public string EventRecValidFlag { get; set; } // char(16), null

        public string EventImportanceFlag { get; set; } // char(16), null

        public string EventAutoUploadFlag { get; set; } // char(16), null

        public int? DIClctIntval { get; set; } // int, null

        public int? AIClctIntval { get; set; } // int, null

        public int? SmartClctIntval { get; set; } // int, null

        public string CtrlLineValidFlag { get; set; } // char(8), null

        public string PwrSaveValidFlag { get; set; } // char(4), null

        public byte? PwrSaveSwitchMaxPos { get; set; } // tinyint, null

        public string CabID { get; set; } // char(24), null

        public string Longitude { get; set; } // char(22), null

        public string Latitude { get; set; } // char(22), null

        public int? IsSingleLampFunc { get; set; } // int, null

        public byte? TmnCommErrTestIntval { get; set; } // tinyint, null

        public byte? RouterCommErrTestIntval { get; set; } // tinyint, null

        public byte? SingLampOpenClctDelay { get; set; } // tinyint, null

        public byte? SingLampCloseClctDelay { get; set; } // tinyint, null

        public byte? SingLampCurrClctDelay { get; set; } // tinyint, null

        public byte? SlampOverILimtVal { get; set; } // tinyint, null

        public byte? SlampOverILRecovVal { get; set; } // tinyint, null

        public byte? SlampLowILimtVal { get; set; } // tinyint, null

        public byte? SlampLowIRecovVal { get; set; } // tinyint, null

        public double? SlaCapFailEvtPFLimtVal { get; set; } // float, null

        public double? SlaCapFailEvtRecoPFLimtVal { get; set; } // float, null

        public byte? SlaFailEvtILimitVal { get; set; } // tinyint, null

        public byte? SlaFailEvtIRecovVal { get; set; } // tinyint, null

        public byte? SlaFuseErrEvtILimtVal { get; set; } // tinyint, null

        public byte? SlaFuseErrEvtIRecoVal { get; set; } // tinyint, null
    }
}
