﻿using System;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SaveMyMoney
{
    /// <summary>
    /// Логика взаимодействия для FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        List<Grid> grids_menu = new List<Grid>();
        List<Grid> grids = new List<Grid>(); //массив гридов для эффектов
        string bufer;
        string lang;
        int jar;
        List<Label> jar_lab = new List<Label>();
        public FirstWindow(string lang)
        {
            this.lang = lang;
            if (lang == "RUS")
            { 
                this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/Resorses/Dictionary_rus.xaml") };
            } //смена языка
            else
            {
                this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/Resorses/Dictionary_eng.xaml") };
            }

                InitializeComponent();

            Grid_Menu_Button_1.MouseUp += Grid_Menu_Button_1_MouseUp;
            Grid_Menu_Button_1.MouseUp += Jar1_switch;
            Grid_Menu_Button_2.MouseUp += Grid_Menu_Button_1_MouseUp;
            Grid_Menu_Button_2.MouseUp += Jar2_switch;
            Grid_Menu_Button_3.MouseUp += Grid_Menu_Button_1_MouseUp;
            Grid_Menu_Button_3.MouseUp += Jar3_switch;
            Grid_Menu_Button_4.MouseUp += Grid_Menu_Button_1_MouseUp;
            Grid_Menu_Button_4.MouseUp += Jar4_switch;
            Grid_Menu_Button_5.MouseUp += Grid_Menu_Button_1_MouseUp;
            Grid_Menu_Button_5.MouseUp += Jar5_switch;
            Grid_Menu_Button_6.MouseUp += Grid_Menu_Button_1_MouseUp;
            Grid_Menu_Button_6.MouseUp += Jar6_switch;

            DropShadowEffect Shadow_50_ = Shadow_50;
            DropShadowEffect Shadow_none_ = Shadow_none;
            grids.Add(Grid_Menu_Button_1);
            grids.Add(Grid_Menu_Button_2);
            grids.Add(Grid_Menu_Button_3);
            grids.Add(Grid_Menu_Button_4);
            grids.Add(Grid_Menu_Button_5);
            grids.Add(Grid_Menu_Button_6);
            grids.Add(Grid_moneyIn_menu_button_1);
            grids.Add(Grid_moneyIn_menu_button_2);
            grids.Add(Grid_moneyIn_menu_button_3);
            grids.Add(Grid_moneyIn_menu_button_4);
            grids.Add(Grid_text_box_1);
            grids.Add(Grid_text_box_2);
            grids.Add(Grid_text_box_3);
            grids.Add(Grid_text_box_1_Copy);
            grids.Add(Grid_text_box_2_Copy);
            grids.Add(Grid_text_box_3_Copy);
            grids.Add(Grid_text_box_3_Copy1);
            grids.Add(Expense_Name_t);
            grids.Add(Expense_Money_t);
            grids.Add(Expense_Desc_t);
            grids.Add(Expense_Hist_btn);
            grids.Add(Expense_Plan_btn);
            grids.Add(Expense_Add_btn);


            
            jar_lab.Add(jar1_lab);
            jar_lab.Add(jar2_lab);
            jar_lab.Add(jar3_lab);
            jar_lab.Add(jar4_lab);
            jar_lab.Add(jar5_lab);
            jar_lab.Add(jar6_lab);


            foreach (Grid item in grids) //события изменения эффекта тени для всех гридов в массиве
            {
                    item.MouseEnter += Grid_Menu_Button_1_MouseEnter;
                    item.MouseLeave += Grid_Menu_Button_1_MouseLeave;
                    item.Effect = Shadow_50;
            }

            grids_menu.Add(Settings_grid);
            grids_menu.Add(LogOut_grid);
            grids_menu.Add(Language_grid);
            grids_menu.Add(Onceamonth);
            grids_menu.Add(Onceaweek);
            grids_menu.Add(Onceayear);

            foreach (Grid item in grids_menu) //события изменения эффекта тени для всех гридов в массиве
            {
                item.MouseEnter += Settings_grid_MouseEnter;
                item.MouseLeave += Settings_grid_MouseLeave;
            }
            
        }

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        private void Main_center_button_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_Menu_Button_1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MoneyIn.Visibility = Visibility.Hidden;
            Bottle.Visibility = Visibility.Visible;
        }

        private void Jar1_switch(object sender, MouseButtonEventArgs e)
        {
            jar = 1;
            foreach (Label a in jar_lab)
            {
                a.Visibility = Visibility.Hidden;
            }
            jar1_lab.Visibility = Visibility.Visible;

        }

        private void Jar2_switch(object sender, MouseButtonEventArgs e)
        {
            jar = 2;
            foreach (Label a in jar_lab)
            {
                a.Visibility = Visibility.Hidden;
            }
            jar2_lab.Visibility = Visibility.Visible;
        }

        private void Jar3_switch(object sender, MouseButtonEventArgs e)
        {
            jar = 3;
            foreach (Label a in jar_lab)
            {
                a.Visibility = Visibility.Hidden;
            }
            jar3_lab.Visibility = Visibility.Visible;
        }

        private void Jar4_switch(object sender, MouseButtonEventArgs e)
        {
            jar = 4;
            foreach (Label a in jar_lab)
            {
                a.Visibility = Visibility.Hidden;
            }
            jar4_lab.Visibility = Visibility.Visible;
        }

        private void Jar5_switch(object sender, MouseButtonEventArgs e)
        {
            jar = 5;
            foreach (Label a in jar_lab)
            {
                a.Visibility = Visibility.Hidden;
            }
            jar5_lab.Visibility = Visibility.Visible;
        }

        private void Jar6_switch(object sender, MouseButtonEventArgs e)
        {
            jar = 6;
            foreach (Label a in jar_lab)
            {
                a.Visibility = Visibility.Hidden;
            }
            jar6_lab.Visibility = Visibility.Visible;
        }

        private void Grid_Menu_Button_1_MouseEnter(object sender, MouseEventArgs e)
        {
            Grid grid = sender as Grid;
            grid.Effect = Shadow_none;
        }

        private void Grid_Menu_Button_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Grid grid = sender as Grid;
            grid.Effect = Shadow_50;
        }

        private void Text_box_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "")
                textBox.Text = bufer;
        }

        private void Text_box_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bufer = textBox.Text;
            if (textBox.Text == bufer)
                textBox.Text = "";
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Settings_grid_MouseEnter(object sender, MouseEventArgs e)
        {
            Grid grid = sender as Grid;
            grid.Background = (Brush)TryFindResource("Trigger");
        }

        private void Settings_grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Grid grid = sender as Grid;
            grid.Background = default(Brush);
        }
        bool settings = false;
        private void Settings_grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (settings)
            {
                settings = false;
                Settings.Visibility = Visibility.Hidden;
            }
            else
            {
                settings = true;
                Settings.Visibility = Visibility.Visible;
            }
     
        }

        private void Settings_LostFocus(object sender, RoutedEventArgs e)
        {
            Settings.Visibility = Visibility.Hidden;
        }

        private void Language_grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (lang == "ENG")
            {
                lang = "RUS";
                this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/Resorses/Dictionary_rus.xaml") };
            }
            else
            {
                lang = "ENG";
                this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/Resorses/Dictionary_eng.xaml") };
            }
        }

        private void Grid_text_box_3_Copy1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            PeriodT.Content = "";
            Period.Visibility = Visibility.Visible;

        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Label label = sender as Label;
            PeriodT.Content = label.Content;
            Period.Visibility = Visibility.Hidden;
        }

        private void Main_center_button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MoneyIn.Visibility = Visibility.Visible;
            Bottle.Visibility = Visibility.Hidden;
        }
    }
}
