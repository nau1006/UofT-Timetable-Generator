﻿namespace UoftTimetableGenerator.DataModels
{
    public class Session
    {
        public Session()
        {
        }

        // Constructor used to convert datacontext.session to datamodels.session
        internal Session(DataContext.Session oldSession)
        {
            if (oldSession.Building == null)
                FallBuildingCode = "";
            else
                FallBuildingCode = oldSession.Building.BuildingCode;

            if (oldSession.Building1 == null)
                WinterBuildingCode = "";
            else
                WinterBuildingCode = oldSession.Building1.BuildingCode;

            FallRoomNumber = oldSession.Fall_RoomNumber;
            WinterRoomNumber = oldSession.Winter_RoomNumber;
            StartTime = oldSession.StartTime.GetValueOrDefault(0);
            EndTime = oldSession.EndTime.GetValueOrDefault(0);
        }

        public string FallBuildingCode { get; set; }
        public string WinterBuildingCode { get; set; }
        public string FallRoomNumber { get; set; }
        public string WinterRoomNumber { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
    }
}