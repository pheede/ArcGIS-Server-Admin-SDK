﻿/*
    Copyright (c) 2012 Shawn Kendrot
    This license governs use of the accompanying software. If you use the software, you
    accept this license. If you do not accept the license, do not use the software.

    Conditions and Limitations
    (A) No Trademark License- This license does not grant you rights to use any contributors' name, logo, or trademarks.
    (B) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, 
        your patent license from such contributor to the software ends automatically.
    (C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, and attribution
        notices that are present in the software.
    (D) If you distribute any portion of the software in source code form, you may do so only under this license by 
        including a complete copy of this license with your distribution. If you distribute any portion of the software 
        in compiled or object code form, you may only do so under a license that complies with this license.
    (E) The software is licensed "as-is." You bear the risk of using it. The contributors give no express warranties, 
        guarantees or conditions. You may have additional consumer rights under your local laws which this license 
        cannot change. To the extent permitted under your local laws, the contributors exclude the implied warranties of 
        merchantability, fitness for a particular purpose and non-infringement.
  
    For more information see http://www.microsoft.com/en-us/openness/licenses.aspx
*/

namespace VisuallyLocated.ArcGIS.Server
{
    public class ServiceStatisticsSummary
    {
        public string FolderName { get; set; }
        public string ServiceName { get; set; }
        public ServiceType Type { get; set; }
        public string StartTime { get; set; }
        public int Max { get; set; }
        public int Busy { get; set; }
        public int Free { get; set; }
        public int Initializing { get; set; }
        public int NotCreated { get; set; }
        public int Transactions { get; set; }
        public int TotalBusyTime { get; set; }
        public bool IsStatisticsAvailable { get; set; }
    }
}
