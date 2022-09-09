using System.Text;
using System.Windows;

namespace CollectionViewSourceBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// ビューモデル
        /// </summary>
        private MainWindowVM _vm;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainWindowVM();
            DataContext = _vm;
        }

        /// <summary>
        /// 行追加ボタン押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRow_Click(object sender, RoutedEventArgs e)
        {
            _vm.PersonList.Add(new Person());
        }

        /// <summary>
        /// データバインドチェックボタン押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckDataBind_Click(object sender, RoutedEventArgs e)
        {
            var sb = new StringBuilder();
            foreach (var person in _vm.PersonList)
            {
                sb.AppendLine($"{person.FirstName} {person.LastName} ({person.Age})");
            }
            MessageBox.Show(this, sb.ToString());
        }
    }
}
