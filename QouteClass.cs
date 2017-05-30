using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MyQuotes
{
    public class Qoutes123
    {
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        string _Text;
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public Qoutes123() { }


        public Qoutes123(int Qid, string QText)
        {
            this.Id = Qid;
            this.Text = QText;
        }
    }
}
