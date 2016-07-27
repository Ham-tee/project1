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
using ThinkLib;

namespace my_string
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int length(string s)
        {
            int a = 0;
            foreach (char b in s)
            {
                a++;
            }
            return a;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(length("1234"), 4);
            Tester.TestEq(length("sgdjfkg"), 7);
            Tester.TestEq(length("bbddjhgdkg"), 10);
            Tester.TestEq(length("playground1234"), 14);
            Tester.TestEq(length("lkjhfuythjdbgadff"), 17);
            Tester.TestEq(length("  "), 2);
        }
        bool contains(string s, string subs)
        {
            string okay = "";
            foreach (char b in s)
            {
                foreach (char r in subs)
                {
                    if (b == r)
                    {
                        okay = okay + b;
                        if (okay == subs)
                        {
                            return true;
                        }
                        break;
                    }
                }

            }
            return false;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(contains("hello", "llo"), true);
            Tester.TestEq(contains("say", "a"), true);
            Tester.TestEq(contains("morning", "morn"), true);
            Tester.TestEq(contains("bronz", "ccc"), false);
            Tester.TestEq(contains("jezz bool", "super"), false);
            Tester.TestEq(contains("boundig", "boun"), true);
            Tester.TestEq(contains("constant", "con"), true);
            Tester.TestEq(contains("physical", "cuf"), false);
            Tester.TestEq(contains("xxyxx", "x"), true);
        }
        int indexOf(string s, string subs)
        {
            int c = 0;
            for (int a = 0; a < length(s); a++)
            {
                if (subs[c] == s[a])
                {
                    return a;
                }
            }
            return -1;
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(indexOf("xxyxx", "y"), 2);
            Tester.TestEq(indexOf("botanist", "s"), 6);
            Tester.TestEq(indexOf("kingdom", "k"), 0);
            Tester.TestEq(indexOf("funds", "s"), 4);
            Tester.TestEq(indexOf("birds", "x"), -1);
            Tester.TestEq(indexOf("queens", "s"), 5);
            Tester.TestEq(indexOf("suyean", "a"), 4);
            Tester.TestEq(indexOf("modern", "r"), 4);
            Tester.TestEq(indexOf("bulk", "k"), 3);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {

        }
        string insertSubString(string s, string x, int pos)
        {
            string result = "";
            for (int a = 0; a < length(s); a++)
            {
                if (a < pos)
                {
                    result = result + s[a];
                }
                if (a == pos)
                {
                    result = result + x + s[a];
                }
                if (a > pos)
                {
                    result = result + s[a];
                }
            }
            return result;
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(insertSubString("xxxx", "yy", 2), "xxyyxx");
            Tester.TestEq(insertSubString("abcd", "w", 3), "abcwd");
            Tester.TestEq(insertSubString("supermn", "a", 6), "superman");
            Tester.TestEq(insertSubString("gest", "u", 1), "guest");
            Tester.TestEq(insertSubString("falsnes", "w", 6), "falsnews");
            Tester.TestEq(insertSubString("cokingbird", "o", 2), "cookingbird");
        }
        string replaceSubString(string s, string newone, string old)
        {
            string a = "";
            for (int b = 0; b < length(s); b++)
            {
                if (Convert.ToString(s[b])==old)
                {
                    a = a + newone; 
                }
                else
                a = a + s[b];
            }
            return a;
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(replaceSubString("xxyxx", "ooo", "y"), "xxoooxx");
            Tester.TestEq(replaceSubString("abcd", "w", "d"), "abcw");
            Tester.TestEq(replaceSubString("supermon", "a", "o"), "superman");
            Tester.TestEq(replaceSubString("gaest", "u", "a"), "guest");
            Tester.TestEq(replaceSubString("caakingbird", "o","a"), "cookingbird");
        }
        string deleteSubString(string s, string subs)
        {
            return "";                                                                                                                                                                                                                
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(deleteSubString("hello", "llo"),"he");
            Tester.TestEq(deleteSubString("zebras", "s"), "zebra");
            Tester.TestEq(deleteSubString("bananaqwe", "qwe"), "banana");
            Tester.TestEq(deleteSubString("kindoam", "a"), "kingdom");
            Tester.TestEq(deleteSubString("funsking", "s"), "funking");
            Tester.TestEq(deleteSubString("spuerbooling", "ing"), "superbool");
        }
    }
}
