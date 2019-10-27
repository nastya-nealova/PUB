using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Have Interface INotifyProperty Cnahged
using System.ComponentModel;
// CallerMemberName
using System.Runtime.CompilerServices;

namespace PUB
{
    class Payment : INotifyPropertyChanged
    {
        PaymentFilePath payment_path;

        private int payment_id;
        private double sum;
        private bool paid;

        private string source_service;
        private string destination_client;

        private DateTime date_of_receiving;
        private DateTime deadline;

        //load initialise all fields 
        public Payment(int id, double sum, bool paid, string source_service, string destination_client, DateTime receiving, DateTime deadline)
        {
            PaymentId = id;
            Sum = sum;
            Paid = paid;
            SourceService = source_service;
            DestinationClient = destination_client;
            DateOfReceiving = receiving;
            Deadline = deadline;
        }

        // initialise some fields
        public Payment(int id, double sum, string source_service, string destination_client, DateTime deadline)
        {
            PaymentId = id;
            Sum = sum;
            Paid = false;
            SourceService = source_service;
            DestinationClient = destination_client;
            DateOfReceiving = new DateTime(0, 0, 0);
            Deadline = deadline;
        }

        public int PaymentId
        {
            get
            {
                return payment_id;
            }
            private set
            {
                if (value >= 0)
                {
                    payment_id = value;
                    OnPropertyChanged("PaymentId");
                }
            }
        }
        public double Sum
        {
            get
            {
                return sum;
            }
            private set
            {
                if (value > 0)
                {
                    sum = value;
                    OnPropertyChanged("Sum");
                }
            }
        }
        public bool Paid
        {
            get
            {
                return paid;
            }
            private set
            {
                paid = value;
                OnPropertyChanged("Paid");
            }
        }

        public string SourceService
        {
            get
            {
                return source_service;
            }
            private set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    source_service = value;
                    OnPropertyChanged("SourceService");
                }
            }
        }
        public string DestinationClient
        {
            get
            {
                return destination_client;
            }
            private set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    source_service = value;
                    OnPropertyChanged("DestinationClient");
                }
            }
        }

        public DateTime DateOfReceiving
        {
            get
            {
                return date_of_receiving;
            }
            private set
            {
                if (value > deadline)
                {
                    date_of_receiving = value;
                }
            }
        }
        public DateTime Deadline
        {
            get
            {
                return deadline;
            }
            private set
            {
                if (value != null)
                {
                    deadline = value;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
