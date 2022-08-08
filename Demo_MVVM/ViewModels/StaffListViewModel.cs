using System;
using System.Collections.ObjectModel;
using Demo_MVVM.Models;

namespace Demo_MVVM.ViewModels
{
    public class StaffListViewModel : FreshMvvm.FreshBasePageModel
    {
        private ObservableCollection<StaffModel> myList;

        public ObservableCollection<StaffModel> MyList
        {
            get { return myList; }
            set { myList = value; }
        }
        public StaffListViewModel()
        {
            MyList = new ObservableCollection<StaffModel>();

            for (int i = 1; i < 30; i++)
            {
                MyList.Add(new StaffModel() { ID = i, Name = "Student" + i.ToString(), Age = 20 + i, Gender = "Male" });
            }

        }
    }
}

