﻿using System;
using System.Collections.Generic;

namespace ADOPMAUI_Lessons.Views.Lesson03
{
	public partial class StackLayout1 : ContentPage
	{
		public StackLayout1()
		{
			InitializeComponent ();
		}
        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            Title += $"   ({Shell.Current.CurrentState.Location.ToString()})";
        }
	}
}

