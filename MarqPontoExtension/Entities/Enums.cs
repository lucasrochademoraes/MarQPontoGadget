﻿namespace MarqPontoExtension.Entities
{
    public enum EUserPointDayStatus
    {
        None = 0,
        Out = 1,
        Working = 2,
        Done = 3,
        Incorrect = 4,
        Fault = 5
    }

    public enum TypeRequest
    {
        GetInfos = 0,
        GetAjustments = 1,
    }
}
