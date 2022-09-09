using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CollectionViewSourceBinding
{
    internal class MainWindowVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Personリストプロパティ
        /// </summary>
        private ObservableCollection<Person> _personList = new ObservableCollection<Person>();

        public ObservableCollection<Person> PersonList
        {
            get { return this._personList; }
            set
            {
                this._personList = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindowVM()
        {
            // 初期データ登録
            var random = new Random();
            _personList.Add(new Person() { FirstName = "Simeon", LastName = "Sinclair", Age = random.Next(0,100) });
            _personList.Add(new Person() { FirstName = "Marjory", LastName = "Feather", Age = random.Next(0, 100) });
            _personList.Add(new Person() { FirstName = "Gerry", LastName = "Prichard", Age = random.Next(0, 100) });
            _personList.Add(new Person() { FirstName = "Riley", LastName = "Wedderburn", Age = random.Next(0, 100) });
            _personList.Add(new Person() { FirstName = "Marleigh", LastName = "Cocker", Age = random.Next(0, 100) });
        }

        /// <summary>
        /// プロパティ変更イベント
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// プロパティ変更通知メソッド
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
