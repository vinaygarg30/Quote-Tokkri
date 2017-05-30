using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using Windows.Phone.Speech.Synthesis;

namespace MyQuotes
{
    public partial class Page2 : PhoneApplicationPage
    {

        Random rand = new Random();
        SpeechSynthesizer synth;
        public Page2()
        {
            InitializeComponent();
            ApplicationBar.IsVisible = false;
        }

        private void image1_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            textBlock1.Visibility = Visibility.Collapsed;

            P1.Visibility = Visibility.Visible;
            List<Qoutes123> myQoutes = new List<Qoutes123>();
            myQoutes.Add(new Qoutes123(1, "Friendship is born at that moment when one man says to another: What! You too? I thought that no one but myself . . ." + System.Environment.NewLine + System.Environment.NewLine + "– C.S. Lewis"));
            myQoutes.Add(new Qoutes123(2, "A friend is someone who knows all about you and still loves you." + System.Environment.NewLine + System.Environment.NewLine + "– Robert Hubbard"));
            myQoutes.Add(new Qoutes123(3, "Good friends, good books, and a sleepy conscience: this is the ideal life." + System.Environment.NewLine + System.Environment.NewLine + "– Mark Twain"));
            myQoutes.Add(new Qoutes123(4, "Friendship is unnecessary, like philosophy, like art.... It has no survival value; rather it is one of those things which give value to survival." + System.Environment.NewLine + System.Environment.NewLine + "– C.S. Lewis"));
            myQoutes.Add(new Qoutes123(5, "What is a friend? A single soul dwelling in two bodies." + System.Environment.NewLine + System.Environment.NewLine + "– Aristole"));
            myQoutes.Add(new Qoutes123(6, "Friendship is the hardest thing in the world to explain. It's not something you learn in school. But if you haven't learned the meaning of friendship, you really haven't learned anything." + System.Environment.NewLine + System.Environment.NewLine + "– Muhammad Ali"));
            myQoutes.Add(new Qoutes123(7, "Only a true best friend can protect you from your immortal enemies." + System.Environment.NewLine + System.Environment.NewLine + "– Richelle Mead"));
            myQoutes.Add(new Qoutes123(8, "There are no faster or firmer friendships than those formed between people who love the same books." + System.Environment.NewLine + System.Environment.NewLine + "– Benjamin Franklin"));
            myQoutes.Add(new Qoutes123(9, "Words are easy, like the wind; Faithful friends are hard to find." + System.Environment.NewLine + System.Environment.NewLine + "– William Shakespeare"));
            myQoutes.Add(new Qoutes123(10, "The capacity for friendship is God's way of apologizing for our families." + System.Environment.NewLine + System.Environment.NewLine + "– Confucius"));
            myQoutes.Add(new Qoutes123(11, "Friendship marks a life even more deeply than love. Love risks degenerating into obsession, friendship is never anything but sharing." + System.Environment.NewLine + System.Environment.NewLine + "– Elie Wiesel"));
            myQoutes.Add(new Qoutes123(12, "They come into being not through demonstration but through revelation, through the medium of powerful personalities." + System.Environment.NewLine + System.Environment.NewLine + "– Albert Einstein"));
            myQoutes.Add(new Qoutes123(13, "Harold like the rest of us, had many impressions which saved him the trouble of distinct ideas." + System.Environment.NewLine + System.Environment.NewLine + "– George Eliot"));
            myQoutes.Add(new Qoutes123(14, "Anybody can sympathise with the sufferings of a friend, but it requires a very fine nature to sympathise with a friend's success." + System.Environment.NewLine + System.Environment.NewLine + "– Oscar Wilde"));
            myQoutes.Add(new Qoutes123(15, "Friendship- my definition- is built on two things. Respect and trust. Both elements have to be there. And it has to be mutual. You can have respect for someone, but if you don't have trust, the friendship will crumble." + System.Environment.NewLine + System.Environment.NewLine + "– Stieg Barrson"));
            myQoutes.Add(new Qoutes123(16, "A faithful friend is a strong defense and he that hath found him hath found a treasure." + System.Environment.NewLine + System.Environment.NewLine + "– Louisa May Alcott"));
            myQoutes.Add(new Qoutes123(17, "Friendship is everything. Friendship is more than talent. It is more than the government. It is almost the equal of family. " + System.Environment.NewLine + System.Environment.NewLine + "– Oprah Winfrey"));
            myQoutes.Add(new Qoutes123(18, "A friend is someone who gives you total freedom to be yourself." + System.Environment.NewLine + System.Environment.NewLine + "– Jim Morrison"));
            myQoutes.Add(new Qoutes123(19, "True friends are like diamonds – bright, beautiful, valuable, and always in style." + System.Environment.NewLine + System.Environment.NewLine + "– Nichole Riche"));
            myQoutes.Add(new Qoutes123(20, "You cannot shake hands with a clenched fist." + System.Environment.NewLine + System.Environment.NewLine + "– Indira Gandhi"));
            myQoutes.Add(new Qoutes123(21, "A wise man gets more use from his enemies than a fool from his friends." + System.Environment.NewLine + System.Environment.NewLine + "– Baltsar Glaccian"));
            myQoutes.Add(new Qoutes123(22, "New friends can often have a better time together than old friends." + System.Environment.NewLine + System.Environment.NewLine + "– Scott Fitzerald"));
            myQoutes.Add(new Qoutes123(23, "Friendship is always a sweet responsibility, never an opportunity." + System.Environment.NewLine + System.Environment.NewLine + "– Khalil Gibrian"));
            myQoutes.Add(new Qoutes123(24, "True friendship is like sound health; the value of it is seldom known until it be lost.." + System.Environment.NewLine + System.Environment.NewLine + "– Charles Colton"));
            myQoutes.Add(new Qoutes123(25, "Friendship is delicate as a glass, once broken it can be fixed but there will always be cracks." + System.Environment.NewLine + System.Environment.NewLine + "– Wakar Ahmad"));
            myQoutes.Add(new Qoutes123(26, "When friendships are real, they are not glass threads or frost work, but the solidest things we can know." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Widow Emerson"));
            myQoutes.Add(new Qoutes123(27, "When you choose your friends, don't be short-changed by choosing personality over character." + System.Environment.NewLine + System.Environment.NewLine + "– Charles Darwin"));
            myQoutes.Add(new Qoutes123(28, "The only person that can ever truly make you happy is yourself. Stop depending on everyone else."));
            myQoutes.Add(new Qoutes123(29, "A friend is someone with whom you dare to be yourself."));
            myQoutes.Add(new Qoutes123(30, "“Close friends are truly life's treasures. Sometimes they know us better than we know ourselves. With gentle honesty, they are there to guide and support us, to share our laughter and our tears. Their presence reminds us that we are never really alone."));
            myQoutes.Add(new Qoutes123(31, "The world is never just black and white, right or wrong, one way or another. Try and see things from as many points of view as possible"));
            myQoutes.Add(new Qoutes123(32, "Constant use had not worn ragged the fabric of their friendship." + System.Environment.NewLine + System.Environment.NewLine + "– Dorothy Parker"));
            myQoutes.Add(new Qoutes123(33, " Friends are honest with each other. Even if the truth hurts."));
            myQoutes.Add(new Qoutes123(34, "When you're jealous or find yourself filled with hate for someone/something, stop. The only person its hurting is you."));
            myQoutes.Add(new Qoutes123(35, "Although the newest, most expensive material things may make you feel as if you’re a better person, they won’t hold you at night or listen to you when you need it. Make sure your priorities make sense."));
            myQoutes.Add(new Qoutes123(36, "Friendship is’nt about whom you have known the longest… It’s about who came, and never left your side."));
            myQoutes.Add(new Qoutes123(37, "Friendship improves happiness, and abates misery, by doubling our joys, and dividing our grief."));
            myQoutes.Add(new Qoutes123(38, "A good friend is a connection to life - a tie to the past, a road to the future, the key to sanity in a totally insane world.. "));
            myQoutes.Add(new Qoutes123(39, "We are best friends,but remember that when you fall! I’ll pick you up after i finish laughing."));
            myQoutes.Add(new Qoutes123(40, "Betrayal is the only truth that sticks." + System.Environment.NewLine + System.Environment.NewLine + "–  Arthur Miller"));
            myQoutes.Add(new Qoutes123(41, "Old friends pass away, new friends appear. It is just like the days. An old day passes, a new day arrives. The important thing is to make it meaningful: a meaningful friend – or a meaningful day." + System.Environment.NewLine + System.Environment.NewLine + "– Fyodor Dostoevsky"));
            myQoutes.Add(new Qoutes123(42, "Friendship often ends in love. But love in friendship; never." + System.Environment.NewLine + System.Environment.NewLine + " – Charles Colton"));
            myQoutes.Add(new Qoutes123(43, "My advice to you is not to inquire why or whither, but just enjoy your ice cream while it’s on your plate. " + System.Environment.NewLine + System.Environment.NewLine + "– Thornton Wilder"));
            myQoutes.Add(new Qoutes123(44, "Enjoy the little things, for one day you may look back and realize they were the big things." + System.Environment.NewLine + System.Environment.NewLine + "– Robert Brault"));
            myQoutes.Add(new Qoutes123(45, "Friends should be like books, few, but hand-selected." + System.Environment.NewLine + System.Environment.NewLine + "–  C.J. Langenhoven"));
            myQoutes.Add(new Qoutes123(46, "When a friend is in trouble, don't annoy him by asking if there is anything you can do. Think up something appropriate and do it.." + System.Environment.NewLine + System.Environment.NewLine + "– E.W. Howe"));
            myQoutes.Add(new Qoutes123(47, "Friendship is selfless love, care, respect, and honor not a profitable opportunity." + System.Environment.NewLine + System.Environment.NewLine + "– Santosh Kalwar"));
            myQoutes.Add(new Qoutes123(48, "You can love somebody without it being like that. You keep them a stranger, a stranger who's a friend." + System.Environment.NewLine + System.Environment.NewLine + "– Truman Capote"));
            myQoutes.Add(new Qoutes123(49, "The better part of one's life consists of his friendships." + System.Environment.NewLine + System.Environment.NewLine + "– Abraham Lincoln"));
            myQoutes.Add(new Qoutes123(50, "Everyone calls himself a friend, but only a fool relies on it: nothing is commoner than the name, nothing rarer than the thing." + System.Environment.NewLine + System.Environment.NewLine + "– Jean La Fontaine"));
            myQoutes.Add(new Qoutes123(51, "You have brains in your head and feet in your shoes.  You can steer yourself any direction you choose.  You’re on your own and you know what you know.  And you are the one who’ll decide where to go." + System.Environment.NewLine + System.Environment.NewLine + "– Dr. Seuss"));
            myQoutes.Add(new Qoutes123(52, "I am unfolding in fulfilling ways.  Only good can come to me.  I now express health, happiness, prosperity, and peace of mind."));
            myQoutes.Add(new Qoutes123(53, "Know that joy is rarer, more difficult, and more beautiful than sadness.  Once you make this all-important discovery, you must embrace joy as a moral obligation." + System.Environment.NewLine + System.Environment.NewLine + "– Andre Gide"));
            myQoutes.Add(new Qoutes123(54, "A friendship like love is warm;a love like friendship is steady." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(55, "Friendship can weather most things and thrive in thin soil;but it needs a little mulch of letters and phone calls and small, silly presents every so often – just to save it from drying out completely." + System.Environment.NewLine + System.Environment.NewLine + "– Maya Angelou"));
            myQoutes.Add(new Qoutes123(56, "A friendship founded on business is better than a business founded on friendship." + System.Environment.NewLine + System.Environment.NewLine + "– Louise Hay"));
            myQoutes.Add(new Qoutes123(57, "A good friend keeps your secrets for you. A best friend helps you keep your own secrets." + System.Environment.NewLine + System.Environment.NewLine + "– Eleanor Roosevelt"));
            myQoutes.Add(new Qoutes123(58, "A hug is worth a thousand words. A friend is worth more.” True friendship is like sound health;the value of it is seldom known until it be lost." + System.Environment.NewLine + System.Environment.NewLine + "– Johann von Goethe"));
            myQoutes.Add(new Qoutes123(59, "A loyal friend laughs at your jokes when they’re not so good, and sympathizes with your problems when they’re not so bad." + System.Environment.NewLine + System.Environment.NewLine + "– Douglas Adams"));
            myQoutes.Add(new Qoutes123(60, "A passion for politics stems usually from an insatiable need, either for power, or for friendship and adulation, or a combination of both." + System.Environment.NewLine + System.Environment.NewLine + "– Henri Frederic Amiel"));
            myQoutes.Add(new Qoutes123(61, "A person only likes his friend to the degree he or she relates and connects to his character." + System.Environment.NewLine + System.Environment.NewLine + "– Anonymous"));
            myQoutes.Add(new Qoutes123(62, "When the grass looks greener on the other side of the fence, it may be that they take better care of it there." + System.Environment.NewLine + System.Environment.NewLine + "– Cecil Selig"));
            myQoutes.Add(new Qoutes123(63, "A quarrel between friends, when made up, adds a new tie to friendship." + System.Environment.NewLine + System.Environment.NewLine + "– Nancy Rathburn"));
            myQoutes.Add(new Qoutes123(64, "A real friend is one who walks in when the rest of the world walks out." + System.Environment.NewLine + System.Environment.NewLine + "– Sally Kempton"));
            myQoutes.Add(new Qoutes123(65, "A snowball in the face is surely the perfect beginning to a lasting friendship." + System.Environment.NewLine + System.Environment.NewLine + "– Lemony Snicket"));
            myQoutes.Add(new Qoutes123(66, "A troublemaker plants seeds of strife;gossip separates the best of friends.." + System.Environment.NewLine + System.Environment.NewLine + "– David Brinkley"));
            myQoutes.Add(new Qoutes123(67, "A true friend is the most precious of all possessions and the one we take the least thought about acquiring." + System.Environment.NewLine + System.Environment.NewLine + "– Louise Hay"));
            myQoutes.Add(new Qoutes123(68, "A true friend sees the good in everything, and brings out the best in the worst of things." + System.Environment.NewLine + System.Environment.NewLine + "– Mary Tyler Moore"));
            myQoutes.Add(new Qoutes123(69, "Friendship is always a sweet responsibility, never an opportunity." + System.Environment.NewLine + System.Environment.NewLine + " – Louise Hay"));
            myQoutes.Add(new Qoutes123(70, "Friendship is the only cement that will ever hold the world together." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(71, "Friendship is not a big things, it’s a million little things." + System.Environment.NewLine + System.Environment.NewLine + "– Hans Hofmann"));
            myQoutes.Add(new Qoutes123(72, "Best friends can see the difference between your fake smile and the real one.." + System.Environment.NewLine + System.Environment.NewLine + "– Bill Gates"));
            myQoutes.Add(new Qoutes123(73, "A true friend is the only one who never gets tired of listening to your own pointless dramas."));
            myQoutes.Add(new Qoutes123(74, "Friendships are fragile things and require as much care in handling as any other fragile and precious thing."));
            myQoutes.Add(new Qoutes123(75, "True friends pick you up when you fall…But special ones don’t let you fall."));

            int ran = rand.Next(1, 100);
            foreach (Qoutes123 a in myQoutes)
            {
                if (a.Id == ran)
                {
                    txtqoutes.Text = a.Text;
                }
            }


        }

        private void image1_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            P1.Visibility = Visibility.Collapsed;
            ApplicationBar.IsVisible = true;
        }



        private async void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            synth = new SpeechSynthesizer();

            // Query for a voice that speaks english
            IEnumerable<VoiceInformation> englishVoices = from voice in InstalledVoices.All
                                                          where voice.Language == "en-US"
                                                          select voice;

            // Set the voice as identified by the query.
            synth.SetVoice(englishVoices.ElementAt(0));

            // Count in english.
            await synth.SpeakTextAsync(txtqoutes.Text);
        }



   



        private void image2_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            Clipboard.SetText(txtqoutes.Text);
            MessageBox.Show("Copied Successfully");

        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/about.xaml", UriKind.Relative));
        }

       

    }
}