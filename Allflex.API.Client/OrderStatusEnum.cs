﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Allflex.API.Client
{
    public enum OrderStatusEnum
    {
        Created,
        Error,
        CustomerUpdated,
        Confirmed,
        InSelection, // Job In Review / Prestage
        Selected, // Job Scheduled / Queued
        InProduction,// In Production (%)
        QcChecked,// QC Checked (%)
        Dispatched, //
        Shipped,
        Invoiced,
        Canceled
    }
}
