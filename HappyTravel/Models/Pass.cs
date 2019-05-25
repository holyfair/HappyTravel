using System;

namespace HappyTravel.Models
{
    [Serializable]
    internal class Pass
    {
        #region Fields
        private string _passNumber;
        private string _status;
        private int _price;
        private DateTime _startDate;
        private DateTime _endDate;
        private int _duration;
        private int _contractNumber;
        #endregion

        #region Properties
        public string PassNumber { get => _passNumber; set => _passNumber = value; }
        public string Status { get => _status; set => _status = value; }
        public int Price { get => _price; set => _price = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public int Duration { get => _duration; set => _duration = value; }
        public int ContractNumber { get => _contractNumber; set => _contractNumber = value; }

        #endregion

        #region Constructor
        public Pass(string passNumber, string status, int price, DateTime startDate, DateTime endDate, int duration, int contractNumber)
        {
            PassNumber = passNumber;
            Status = status;
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
            Duration = duration;
            ContractNumber = contractNumber;
        }
        #endregion
    }
}