using System;
using System.ComponentModel;

namespace DetailList
{
	public class Person : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		void OnPropertyChanged (string Prop)
		{
			if (PropertyChanged != null)
				PropertyChanged (this, new PropertyChangedEventArgs (Prop));
		}

		#endregion

		public Person ()
		{
		}

		private string _name;

		public String Name {
			get { 
				return _name;
			}
			set { 
				if (_name != value) {
					_name = value;
					OnPropertyChanged ("Name");
				}
			}
		}

		private string _surname;

		public String Surname {
			get { 
				return _surname;
			}
			set { 
				if (_surname != value) {
					_surname = value;
					OnPropertyChanged ("Surname");
				}
			}
		}

		private int _age;

		public int Age {
			get { 
				return _age;
			}
			set { 
				if (_age != value) {
					_age = value;
					OnPropertyChanged ("Age");
				}
			}
		}

		private bool _visible;

		public bool Visible {
			get { 
				return _visible;
			}
			set { 
				if (_visible != value) {
					_visible = value;
					OnPropertyChanged ("Visible");
				}
			}
		}

		public void ChangeVisible ()
		{
			Visible = !Visible;
		}
	}
}

