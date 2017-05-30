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
using Microsoft.Phone.Shell;

namespace MyQuotes
{
    public partial class MainPage : PhoneApplicationPage
    {
        
        Random rand = new Random();
        SpeechSynthesizer synth;
       
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ApplicationBar.IsVisible = false;
        }

        private void image1_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            textBlock1.Visibility = Visibility.Collapsed;  
          
            P1.Visibility = Visibility.Visible;
            List<Qoutes123> myQoutes = new List<Qoutes123>();
            myQoutes.Add(new Qoutes123(1, "I love you as certain dark things are to be loved, in secret, between the shadow and the soul." + System.Environment.NewLine + System.Environment.NewLine + "– Pabulo Neruda"));
            myQoutes.Add(new Qoutes123(2, "Love is an irresistible desire to be irresistibly desired." + System.Environment.NewLine + System.Environment.NewLine + "– Robert Frost"));
            myQoutes.Add(new Qoutes123(3, "Love is a fruit in season at all times, and within reach of every hand." + System.Environment.NewLine + System.Environment.NewLine + "– Mother Teresa"));
            myQoutes.Add(new Qoutes123(4, "Love is a canvas furnished by Nature and embroidered by imagination." + System.Environment.NewLine + System.Environment.NewLine + "– Voltaire"));
            myQoutes.Add(new Qoutes123(5, "Love is the emblem of eternity; it confounds all notion of time; effaces all memory of a beginning, all fear of an end." + System.Environment.NewLine + System.Environment.NewLine + "– Germaine De Stail"));
            myQoutes.Add(new Qoutes123(6, "Love is not a matter of counting the years . . . But making the years count." + System.Environment.NewLine + System.Environment.NewLine + "– William Wordsworth"));
            myQoutes.Add(new Qoutes123(7, "For pleasures past I do not grieve, nor perils gathering near; My greatest grief is that I leave nothing that claims a tear." + System.Environment.NewLine + System.Environment.NewLine + "– Lord Byron"));
            myQoutes.Add(new Qoutes123(8, "A kiss is a lovely trick designed by nature to stop speech when words become superfluous." + System.Environment.NewLine + System.Environment.NewLine + "– Benjamin Franklin"));
            myQoutes.Add(new Qoutes123(9, "Love is a fabric which never fades, no matter how often it is washed in the water of adversity and grief."+ System.Environment.NewLine + System.Environment.NewLine + "– Robert Fulghum"));
            myQoutes.Add(new Qoutes123(10, "In the arithmetic of love, one plus one equals everything, and two minus one equals nothing." + System.Environment.NewLine + System.Environment.NewLine + "– Confucius"));
            myQoutes.Add(new Qoutes123(11, "You come to love not by finding the perfect person, but by learning to see an imperfect person perfectly." + System.Environment.NewLine + System.Environment.NewLine + "– Sam Keen"));
            myQoutes.Add(new Qoutes123(12, "To love someone deeply gives you strength. Being loved by someone deeply gives you courage." + System.Environment.NewLine + System.Environment.NewLine + "– Lao Tzu"));
            myQoutes.Add(new Qoutes123(13, "Meeting you was fate, becoming your friend was a choice, but falling in love with you was beyond my control." + System.Environment.NewLine + System.Environment.NewLine + "– George Eliot"));
            myQoutes.Add(new Qoutes123(14, "Love is of all passions the strongest, for it attacks simultaneously the head, the heart and the senses." + System.Environment.NewLine + System.Environment.NewLine + "– Karl Marx"));
            myQoutes.Add(new Qoutes123(15, "The soul never thinks without a picture." + System.Environment.NewLine + System.Environment.NewLine + "– Aristotle"));
            myQoutes.Add(new Qoutes123(16, "Love is to love someone for who they are, who they were, and who they will be." + System.Environment.NewLine + System.Environment.NewLine + "– Chris Moore"));
            myQoutes.Add(new Qoutes123(17, "Within you I lose myself. Without you I find myself wanting to become lost again. " + System.Environment.NewLine + System.Environment.NewLine + "– Anonymous"));
            myQoutes.Add(new Qoutes123(18, "Love is the only reality and it is not a mere sentiment. It is the ultimate truth that lies at the heart of creation." + System.Environment.NewLine + System.Environment.NewLine + "– RabindraNath Tagore"));
            myQoutes.Add(new Qoutes123(19, "Whatever is begun in anger, ends in shame" + System.Environment.NewLine + System.Environment.NewLine + "– Benjamin Franklin"));
            myQoutes.Add(new Qoutes123(20, "Love is not who you can see yourself with. It is who you can’t see yourself without." + System.Environment.NewLine + System.Environment.NewLine + "– Indira Gandhi"));
            myQoutes.Add(new Qoutes123(21, "When angry, count four; when very angry, swear." + System.Environment.NewLine + System.Environment.NewLine + "– Mark Twain"));
            myQoutes.Add(new Qoutes123(22, "Love has nothing to do with what you are expecting to get–only with what you are expecting to give–which is everything." + System.Environment.NewLine + System.Environment.NewLine + "– Katherine Hupbern"));
            myQoutes.Add(new Qoutes123(23, "Your smile is like the sunshine and it brightens up my day. Your thoughts in my head create the sweetest melody and I can’t help but fall for you" + System.Environment.NewLine + System.Environment.NewLine + "– Anonymous"));
            myQoutes.Add(new Qoutes123(24, "Our character is basically a composite of our habits. Because they are consistent,often unconcious patterns, they constantly, daily, express our character" + System.Environment.NewLine + System.Environment.NewLine + "– Stephen R. Covey"));
            myQoutes.Add(new Qoutes123(25, "Love doesn’t make the world go round. Love is what makes the ride worthwhile." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(26, "There is always some madness in love. But there is also always some reason in madness." + System.Environment.NewLine + System.Environment.NewLine + "– Freidrich William"));
            myQoutes.Add(new Qoutes123(27, "Falling in love is like jumping off a really tall building. Your brain tells you it is not a good idea, but your heart tells you, you can fly." + System.Environment.NewLine + System.Environment.NewLine + "– Anonymous"));
            myQoutes.Add(new Qoutes123(28, "The only person that can ever truly make you happy is yourself. Stop depending on everyone else."));
            myQoutes.Add(new Qoutes123(29, "One is loved because one is loved. No reason is needed for loving."));
            myQoutes.Add(new Qoutes123(30, "Smiling is the ultimate anti-depressant. Smile and laugh out loud, it doesn’t look stupid, I promise."));
            myQoutes.Add(new Qoutes123(31, "Love is like the wind, you can’t see it but you can feel it."));
            myQoutes.Add(new Qoutes123(32, "Gravitation can not be held responsible for people falling in love." + System.Environment.NewLine + System.Environment.NewLine + "– Albert Einstein"));
            myQoutes.Add(new Qoutes123(33, "Love is that condition in which the happiness of another person is essential to your own. "));
            myQoutes.Add(new Qoutes123(34, "When you're jealous or find yourself filled with hate for someone/something, stop. The only person its hurting is you."));
            myQoutes.Add(new Qoutes123(35, "My love for you is like the universe. It always grows, but it never ends. "));
            myQoutes.Add(new Qoutes123(36, "Step outside your comfort zone- it’s when you’ll really feel alive. "));
            myQoutes.Add(new Qoutes123(37, "Don’t be afraid to be yourself, the people who really matter, don’t mind."));
            myQoutes.Add(new Qoutes123(38, "Let your emotions out sometimes, humans have them for a reason. "));
            myQoutes.Add(new Qoutes123(39, "Celebrate the things you have. Think only positively of the things you don’t (but would like to have) and they too will come."));
            myQoutes.Add(new Qoutes123(40, "Happiness is excitement that has found a settling down place.  But there is always a little corner that keeps flapping around." + System.Environment.NewLine + System.Environment.NewLine + "– E.L. Konigsburg"));
            myQoutes.Add(new Qoutes123(41, "If today I die, I will be at peace because I have known my soul mate and have understood the true meaning of love." + System.Environment.NewLine + System.Environment.NewLine + "– Fyodor Dostoevsky"));
            myQoutes.Add(new Qoutes123(42, "You must first be who you really are, then do what you need to do, in order to have what you want." + System.Environment.NewLine + System.Environment.NewLine + " – Margaret Young"));
            myQoutes.Add(new Qoutes123(43, " I love the way you laugh, I love the way you smile. I love the way you make me feel every single time. You are the one who takes away the blues. That is the reason why I am so in love with YOU! " + System.Environment.NewLine + System.Environment.NewLine + "– Thornton Wilder"));
            myQoutes.Add(new Qoutes123(44, "Enjoy the little things, for one day you may look back and realize they were the big things." + System.Environment.NewLine + System.Environment.NewLine + "– Robert Brault"));
            myQoutes.Add(new Qoutes123(45, "Happiness is when what you think, what you say, and what you do are in harmony." + System.Environment.NewLine + System.Environment.NewLine + "– Mahatma Gandhi"));
            myQoutes.Add(new Qoutes123(46, " Love is a fire. But whether it is going to warm your hearth or burn down your house, you can never tell." + System.Environment.NewLine + System.Environment.NewLine + "– Walt Disney"));
            myQoutes.Add(new Qoutes123(47, " Love is a lot like a backache, it doesn’t show up on X-rays, but you know it’s there." + System.Environment.NewLine + System.Environment.NewLine + "– Eleanor Roosevelt"));
            myQoutes.Add(new Qoutes123(48, "Before you find your handsome prince, you’ve got to kiss a lot of frogs. " + System.Environment.NewLine + System.Environment.NewLine + "– Leonardo DaVinci"));
            myQoutes.Add(new Qoutes123(49, " Love is composed of a single soul inhabiting two bodies." + System.Environment.NewLine + System.Environment.NewLine + "– Manual of the Warrior of Light"));
            myQoutes.Add(new Qoutes123(50, " A boat needs the river to keep floating and I need you for my heart to keep beating." + System.Environment.NewLine + System.Environment.NewLine + "– Anna Quindlen"));
            myQoutes.Add(new Qoutes123(51, "Love is the big booming beat which covers up the noise of hate." + System.Environment.NewLine + System.Environment.NewLine + "– Dr. Seuss"));
            myQoutes.Add(new Qoutes123(52, "The one you love and the one who loves you are never, ever the same person."));
            myQoutes.Add(new Qoutes123(53, "Love cannot be found where it doesn’t exist, nor can it be hidden where it truly does." + System.Environment.NewLine + System.Environment.NewLine + "– Andre Gide"));
            myQoutes.Add(new Qoutes123(54, "Immature love says: 'I love you because I need you.' Mature love says 'I need you because I love you." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(55, "Love doesn't make the world go 'round. Love is what makes the ride worthwhile. " + System.Environment.NewLine + System.Environment.NewLine + "– Maya Angelou"));
            myQoutes.Add(new Qoutes123(56, "Love is a force more formidable than any other. It is invisible - it cannot be seen or measured, yet it is powerful enough to transform you in a moment, and offer you more joy than any material possession could." + System.Environment.NewLine + System.Environment.NewLine + "– Louise Hay"));
            myQoutes.Add(new Qoutes123(57, "True love is eternal, infinite, and always like itself. It is equal and pure, without violent demonstrations: it is seen with white hairs and is always young in the heart." + System.Environment.NewLine + System.Environment.NewLine + "– Eleanor Roosevelt"));
            myQoutes.Add(new Qoutes123(58, "Stolen kisses are always sweetest." + System.Environment.NewLine + System.Environment.NewLine + "– Johann von Goethe"));
            myQoutes.Add(new Qoutes123(59, "Love takes off masks that we fear we cannot live without and know we cannot live within." + System.Environment.NewLine + System.Environment.NewLine + "– Douglas Adams"));
            myQoutes.Add(new Qoutes123(60, "Love is an emotion experienced by the many and enjoyed by the few." + System.Environment.NewLine + System.Environment.NewLine + "– Henri Frederic Amiel"));
            myQoutes.Add(new Qoutes123(61, "Love is like a beautiful flower which I may not touch, but whose fragrance makes the garden a place of delight just the same." + System.Environment.NewLine + System.Environment.NewLine + "– Helen Keller"));
            myQoutes.Add(new Qoutes123(62, "Love yourself first and everything else falls into line. You really have to love yourself to get anything done in this world." + System.Environment.NewLine + System.Environment.NewLine + "– Cecil Selig"));
            myQoutes.Add(new Qoutes123(63, "Love is always bestowed as a gift - freely, willingly and without expectation. We don't love to be loved; we love to love." + System.Environment.NewLine + System.Environment.NewLine + "– Nancy Rathburn"));
            myQoutes.Add(new Qoutes123(64, "It’s hard to fight an enemy who has outposts in your head." + System.Environment.NewLine + System.Environment.NewLine + "– Sally Kempton"));
            myQoutes.Add(new Qoutes123(65, "Love cures people - both the ones who give it and the ones who receive it." + System.Environment.NewLine + System.Environment.NewLine + "– Lemony Snicket"));
            myQoutes.Add(new Qoutes123(66, "Love does not consist in gazing at each other, but in looking outward together in the same direction." + System.Environment.NewLine + System.Environment.NewLine + "– David Brinkley"));
            myQoutes.Add(new Qoutes123(67, "The art of love is largely the art of persistence." + System.Environment.NewLine + System.Environment.NewLine + "– Louise Hay"));
            myQoutes.Add(new Qoutes123(68, "There can be no deep disappointment where there is not deep love." + System.Environment.NewLine + System.Environment.NewLine + "– Martin S. Luther"));
            myQoutes.Add(new Qoutes123(69, "I breathe in the fullness and richness of life.  I observe with joy as life abundantly supports me and supplies me with more good than I can imagine." + System.Environment.NewLine + System.Environment.NewLine + " – Louise Hay"));
            myQoutes.Add(new Qoutes123(70, "Improve your spare moments and they will become the brightest gems in your life." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(71, "The ability to simplify means to eliminate the unnecessary so that the necessary may speak." + System.Environment.NewLine + System.Environment.NewLine + "– Hans Hofmann"));
            myQoutes.Add(new Qoutes123(72, "Love is the only reality and it is not a mere sentiment. It is the ultimate truth that lies at the heart of creation." + System.Environment.NewLine + System.Environment.NewLine + "– RabindraNath Tagore"));
            myQoutes.Add(new Qoutes123(73, "I've learned that people will forget what you said, people will forget what you did, but people will never forget how you made them feel."));
            myQoutes.Add(new Qoutes123(74, "When love is not madness, it is not love."));
            myQoutes.Add(new Qoutes123(75, "Love seeks one thing only: the good of the one loved. It leaves all the other secondary effects to take care of themselves. Love, therefore, is its own reward."));



            int ran = rand.Next(1, 75);
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
            if (txtqoutes.Visibility == Visibility.Visible)
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