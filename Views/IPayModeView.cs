﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IPayModeView
    {
        string PayModeId { get; set; }

        string PayModeName { get; set; }

        string PayModeObservation { get; set; }

        string SearchValue { get; set; }

        bool IsEdit { get; set; }

        bool IsSucessful { get; set; }

        string Message { get; set; }

        event EventHandler SearchEvent;

        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DaleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;



        void SetPayModeListBildingSource(BindingSource payModeBindingSource);
        void Show();

    }
}
