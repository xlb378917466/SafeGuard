﻿/*******************************************************************************
 * Copyright © 2016 分享智慧版权所有
 * Author: Allen
 * 分享智慧
 * 
*********************************************************************************/
using System;

namespace AFX.Data.Entity.SystemSecurity
{
    public class LogEntity : Entity<LogEntity>, ICreationAudited
    {
        public string F_Id { get; set; }
        public DateTime? F_Date { get; set; }
        public string F_Account { get; set; }
        public string F_NickName { get; set; }
        public string F_Type { get; set; }
        public string F_IPAddress { get; set; }
        public string F_IPAddressName { get; set; }
        public string F_ModuleId { get; set; }
        public string F_ModuleName { get; set; }
        public bool? F_Result { get; set; }
        public string F_Description { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
    }
}
