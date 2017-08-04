using Android.App;
using Android.Widget;
using Android.OS;
using SParseMatrix;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace SParseBench
{
    [Activity(Label = "SParseBench", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        SParse parse;
        StopWatch s;

        Button SirBtn;
        Button MyBtn;
        Button ClearBtn;
        TextView ResultTxt;
        EditText numOfTime;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            ClearBtn = FindViewById<Button>(Resource.Id.btnClr);
            SirBtn = FindViewById<Button>(Resource.Id.btnSir);
            MyBtn = FindViewById<Button>(Resource.Id.btnMy);
            ResultTxt = FindViewById<TextView>(Resource.Id.textResult);
            numOfTime = FindViewById<EditText>(Resource.Id.numOfTime);
            SirBtn.Click += SirBtn_Click;
            MyBtn.Click += MyBtn_Click;
            ClearBtn.Click += ClearBtn_Click;
        }

        private void ClearBtn_Click(object sender, System.EventArgs e)
        {
            ResultTxt.Text = "";
        }

        private void MyBtn_Click(object sender, System.EventArgs e)
        {
            if (ResultTxt.Text == "Ready for benchmark")
            {
                ResultTxt.Text = "";
            }
            Task t = new Task(doSomething);
            t.Start();

            void doSomething()
            {
                s.Start();
                for (int i = 0; i < int.Parse(numOfTime.Text); i++)
                {
                    parse.CreateSParseMy();
                }
                s.Stop();
                RunOnUiThread(new Action(()=>ResultTxt.Text += "My time:" + s.Elasped().ToString() + "\n"));
                RunOnUiThread(new Action(() => s.Reset()));
            }
        }


        private void SirBtn_Click(object sender, System.EventArgs e)
        {
            if (ResultTxt.Text == "Ready for benchmark")
            {
                ResultTxt.Text = "";
            }
            Task t = new Task(doSomething);
            t.Start();

            void doSomething()
            {
                s.Start();
                for (int i = 0; i < int.Parse(numOfTime.Text); i++)
                {
                    parse.CreateSParseSir();
                }
                s.Stop();
                RunOnUiThread(new Action(() => ResultTxt.Text += "Sir time :" + s.Elasped().ToString() + "\n"));
                RunOnUiThread(new Action(() => s.Reset()));
            }
        }


        protected override void OnResume()
        {
            base.OnResume();
            parse = new SParse();
            parse.CreateTraditionalMatrix();
            s = new StopWatch();
            ResultTxt.Text = "Ready for benchmark";
        }


    }
}

