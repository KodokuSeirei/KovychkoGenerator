using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KovychkoGenerator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Processing_Click(object sender, RoutedEventArgs e)
        {    
            string before = textboxBeforeProcessing.Text;//Сохранение текста в переменной
             
            string[] words = before.Split(new char[] { ' ' });//Разбор текста на слова                       
            for (int i = 0;  i < words.Length; i++)//Добавление одинарных кавычек
            {              
                textboxPostProcessing.Text += "'" + words[i] + "'";               
            }           
        }
        private void ToClear_Click(object sender, RoutedEventArgs e)
        {
            textboxPostProcessing.Clear();
        }

        private void Processing2_Click(object sender, RoutedEventArgs e)
        {
            
            string before = textboxBeforeProcessing.Text;
            string[] words = before.Split();//Разбор текста на слова
          
           
          
            for (int i = 0; i < words.Length; i++)//Добавление одинарных кавычек
            {
                textboxPostProcessing.Text +=words[i] + "'";               
            }
        }
    }
}
