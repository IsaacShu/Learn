//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JSWebSite
{
    using System;
    using System.Collections.Generic;
    
    public partial class leavestatistics
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long CauseLeaveCount { get; set; }
        public long AnnualLeaveCount { get; set; }
        public long SickLeaveCount { get; set; }
        public long MaternityLeaveCount { get; set; }
        public long MaritalLeaveCount { get; set; }
        public long FuneralLeaveCount { get; set; }
        public int AnnualLeaveInAll { get; set; }
        public int AvailableAnnualLeave { get; set; }
    
        public virtual employeeinfo employeeinfo { get; set; }
    }
}
