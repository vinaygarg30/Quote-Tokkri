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
    public partial class Page3 : PhoneApplicationPage
    {

        Random rand = new Random();
        SpeechSynthesizer synth;
        public Page3()
        {
            InitializeComponent();
            ApplicationBar.IsVisible = false;
        }


        private void image1_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            textBlock1.Visibility = Visibility.Collapsed;


            P1.Visibility = Visibility.Visible;
            List<Qoutes123> myQoutes = new List<Qoutes123>();
            myQoutes.Add(new Qoutes123(1, "How strange that Nature does not knock, and yet does not intrude!" + System.Environment.NewLine + System.Environment.NewLine + "– Emily Dickinson"));
            myQoutes.Add(new Qoutes123(2, "Man’s heart away from nature becomes hard." + System.Environment.NewLine + System.Environment.NewLine + "– Standing Bear"));
            myQoutes.Add(new Qoutes123(3, "The clearest way into the Universe is through a forest wilderness." + System.Environment.NewLine + System.Environment.NewLine + "– John Muir"));
            myQoutes.Add(new Qoutes123(4, "Adopt the pace of nature: her secret is patience." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(5, "Live in each season as it passes; breathe the air, drink the drink, taste the fruit, and resign yourself to the influence of the earth." + System.Environment.NewLine + System.Environment.NewLine + "– Henry David"));
            myQoutes.Add(new Qoutes123(6, "To sit in the shade on a fine day and look upon verdure is the most perfect refreshment.." + System.Environment.NewLine + System.Environment.NewLine + "– Jane Austin"));
            myQoutes.Add(new Qoutes123(7, "One touch of nature makes the whole world kin. " + System.Environment.NewLine + System.Environment.NewLine + "– William Shakespeare"));
            myQoutes.Add(new Qoutes123(8, "Nature reserves the right to inflict upon her children the most terrifying jests. " + System.Environment.NewLine + System.Environment.NewLine + "– Thornton Wilder"));
            myQoutes.Add(new Qoutes123(9, "A lake is the landscape's most beautiful and expressive feature. It is Earth's eye; looking into which the beholder measures the depth of his own nature.." + System.Environment.NewLine + System.Environment.NewLine + "– David Henry"));
            myQoutes.Add(new Qoutes123(10, "Nature never hurries. Atom by atom, little by little she achieves her work." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(11, "The rainbows of life follow the storm.." + System.Environment.NewLine + System.Environment.NewLine + "– Sam Keen"));
            myQoutes.Add(new Qoutes123(12, "Nature does not hurry, yet everything is accomplished." + System.Environment.NewLine + System.Environment.NewLine + "– Lao Tzu"));
            myQoutes.Add(new Qoutes123(13, "Nature is man’s teacher. She unfolds her treasures to his search, unseals his eye, illumes his mind, and purifies his heart; an influence breathes from all the sights and sounds of her existence. " + System.Environment.NewLine + System.Environment.NewLine + "– Alfred Billings"));
            myQoutes.Add(new Qoutes123(14, "A lawn is nature under totalitarian rule." + System.Environment.NewLine + System.Environment.NewLine + "– Michael Pollan"));
            myQoutes.Add(new Qoutes123(15, "A setting sun still whispers a promise for tomorrow." + System.Environment.NewLine + System.Environment.NewLine + "– Jeb Dickerson"));
            myQoutes.Add(new Qoutes123(16, "Nature will bear the closest inspection. She invites us to lay our eye level with her smallest leaf, and take an insect view of its plain." + System.Environment.NewLine + System.Environment.NewLine + "– Henry David"));
            myQoutes.Add(new Qoutes123(17, "Nothing is more beautiful than the loveliness of the woods before sunrise.  " + System.Environment.NewLine + System.Environment.NewLine + "– George Carver"));
            myQoutes.Add(new Qoutes123(18, "Love is the only reality and it is not a mere sentiment. It is the ultimate truth that lies at the heart of creation." + System.Environment.NewLine + System.Environment.NewLine + "– RabindraNath Tagore"));
            myQoutes.Add(new Qoutes123(19, "Nature, in her blind search for life, has filled every possible cranny of the earth with some sort of fantastic creature." + System.Environment.NewLine + System.Environment.NewLine + "– Joseph Wood"));
            myQoutes.Add(new Qoutes123(20, "Flowers are heaven's masterpiece." + System.Environment.NewLine + System.Environment.NewLine + "– Dorothy Parker"));
            myQoutes.Add(new Qoutes123(21, "Plant seeds of happiness, hope, success, and love; it will all come back to you in abundance. This is the law of nature." + System.Environment.NewLine + System.Environment.NewLine + "– Steve Marbolli"));
            myQoutes.Add(new Qoutes123(22, "The world's big and I want to have a good look at it before it gets dark." + System.Environment.NewLine + System.Environment.NewLine + "– John Muir"));
            myQoutes.Add(new Qoutes123(23, "“Love the trees until their leaves fall off, then encourage them to try again next year." + System.Environment.NewLine + System.Environment.NewLine + "– Chad Suggs"));
            myQoutes.Add(new Qoutes123(24, "Love comforteth like sunshine after rain." + System.Environment.NewLine + System.Environment.NewLine + "– Shakespeare"));
            myQoutes.Add(new Qoutes123(25, "Delight in the beauty that surrounds you." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(26, "Look deep into nature, and then you will understand everything better." + System.Environment.NewLine + System.Environment.NewLine + "– Albert Einstein"));
            myQoutes.Add(new Qoutes123(27, "Sunshine is delicious, rain is refreshing, wind braces us up, snow is exhilarating; there is really no such thing as bad weather, only different kinds of good weather." + System.Environment.NewLine + System.Environment.NewLine + "– Anonymous"));
            myQoutes.Add(new Qoutes123(28, "Nature always wears the colors of the spirit."));
            myQoutes.Add(new Qoutes123(29, "In the depth of winter I finally learned that there was in me an invincible summer."));
            myQoutes.Add(new Qoutes123(30, "The sea, once it casts its spell, holds one in its net of wonder forever."));
            myQoutes.Add(new Qoutes123(31, "Every flower is a soul blossoming in nature."));
            myQoutes.Add(new Qoutes123(32, "The woods are lovely, dark and deep. But I have promises to keep, and miles to go before I sleep.." + System.Environment.NewLine + System.Environment.NewLine + "– Robert Frost"));
            myQoutes.Add(new Qoutes123(33, "Green is the prime color of the world, and that from which its loveliness arises. "));
            myQoutes.Add(new Qoutes123(34, "The counterfeit and counterpart of Nature is reproduced in art."));
            myQoutes.Add(new Qoutes123(35, "May your trails be crooked, winding, lonesome, dangerous, leading to the most amazing view. May your mountains rise into and above the clouds."));
            myQoutes.Add(new Qoutes123(36, "There is nothing more beautiful than a rainbow -  but it takes both rain and sunshine to make one.  If life is to be rounded and many-colored, like a rainbow, both joy and sorrow must come to it."));
            myQoutes.Add(new Qoutes123(37, "Don’t be afraid to be yourself, the people who really matter, don’t mind."));
            myQoutes.Add(new Qoutes123(38, "Like a night without starlight, so is a life without love.  "));
            myQoutes.Add(new Qoutes123(39, "Celebrate the things you have. Think only positively of the things you don’t (but would like to have) and they too will come."));
            myQoutes.Add(new Qoutes123(40, "Nature is so powerful, so strong. Capturing its essence is not easy - your work becomes a dance with light and the weather. It takes you to a place within yourself." + System.Environment.NewLine + System.Environment.NewLine + "– Annie Leivobitz"));
            myQoutes.Add(new Qoutes123(41, "The clearest way into the Universe is through a forest wilderness." + System.Environment.NewLine + System.Environment.NewLine + "– John Muir"));
            myQoutes.Add(new Qoutes123(42, "Rain is grace; rain is the sky descending to the earth; without rain, there would be no life." + System.Environment.NewLine + System.Environment.NewLine + " – John Updike"));
            myQoutes.Add(new Qoutes123(43, " I love the way you laugh, I love the way you smile. I love the way you make me feel every single time. You are the one who takes away the blues. That is the reason why I am so in love with YOU! " + System.Environment.NewLine + System.Environment.NewLine + "– Thornton Wilder"));
            myQoutes.Add(new Qoutes123(44, "Enjoy the little things, for one day you may look back and realize they were the big things." + System.Environment.NewLine + System.Environment.NewLine + "– Robert Brault"));
            myQoutes.Add(new Qoutes123(45, "Mother Nature is always speaking. She speaks in a language understood within the peaceful mind of the sincere observer. Leopards, cobras, monkeys, rivers and trees; they all served as my teachers when I lived as a wanderer in the Himalayan foothills." + System.Environment.NewLine + System.Environment.NewLine + "– RadhaNath Swami"));
            myQoutes.Add(new Qoutes123(46, " Some of nature's most exquisite handiwork is on a miniature scale, as anyone knows who has applied a magnifying glass to  a snowflake. " + System.Environment.NewLine + System.Environment.NewLine + "– Rachael Carlson"));
            myQoutes.Add(new Qoutes123(47, " Art is the child of nature in whom we trace the features of the mothers face." + System.Environment.NewLine + System.Environment.NewLine + "– Henry Wadsworth"));
            myQoutes.Add(new Qoutes123(48, "Nature is pleased with simplicity. And nature is no dummy. " + System.Environment.NewLine + System.Environment.NewLine + "– Isaac Newton"));
            myQoutes.Add(new Qoutes123(49, " Nature cannot be tricked or cheated. She will give up to you the object of your struggles only after you have paid her price." + System.Environment.NewLine + System.Environment.NewLine + "– Napolean Hill"));
            myQoutes.Add(new Qoutes123(50, "Nature teaches more than she preaches. There are no sermons in stones. It is easier to get a spark out of a stone than a moral." + System.Environment.NewLine + System.Environment.NewLine + "– Anna Quindlen"));
            myQoutes.Add(new Qoutes123(51, "The color of the mountains is Buddha’s body; the sound of running water is his great speech." + System.Environment.NewLine + System.Environment.NewLine + "– Dogen"));
            myQoutes.Add(new Qoutes123(52, "All the uglinesses of the world can best be forgotten in the beauty of nature! "));
            myQoutes.Add(new Qoutes123(53, "To sit in the shade on a fine day, and look upon verdure is the most perfect refreshment." + System.Environment.NewLine + System.Environment.NewLine + "– Jane Austen"));
            myQoutes.Add(new Qoutes123(54, "Nature does nothing uselessly." + System.Environment.NewLine + System.Environment.NewLine + "– Aristole"));
            myQoutes.Add(new Qoutes123(55, "To become vegetarian is to step into the stream which leads to nirvana. " + System.Environment.NewLine + System.Environment.NewLine + "– Gautam Buddha"));
            myQoutes.Add(new Qoutes123(56, "The sun challenges us to shine, the clouds remind us to move, the birds tell us we too can fly and the sky tells us that there is no limit to our dreams and goal." + System.Environment.NewLine + System.Environment.NewLine + "– Louise Hay"));
            myQoutes.Add(new Qoutes123(57, "Nature never hurries. Atom by atom, little by little she achieves her work." + System.Environment.NewLine + System.Environment.NewLine + "– Eleanor Roosevelt"));
            myQoutes.Add(new Qoutes123(58, "Nature operates in silence to produce what the eyes see." + System.Environment.NewLine + System.Environment.NewLine + "– Johann von Goethe"));
            myQoutes.Add(new Qoutes123(59, "All art is an imitation of nature." + System.Environment.NewLine + System.Environment.NewLine + "– Seneca"));
            myQoutes.Add(new Qoutes123(60, "For in the true nature of things, if we rightly consider, every green tree is far more glorious than if it were made of gold and silver." + System.Environment.NewLine + System.Environment.NewLine + "– Martin Luther"));
            myQoutes.Add(new Qoutes123(61, "The sun, the earth, love, friends, our very breath are parts of the banquet." + System.Environment.NewLine + System.Environment.NewLine + "– Helen Keller"));
            myQoutes.Add(new Qoutes123(62, "Autumn arrives in early morning, but spring at the close of a winter day." + System.Environment.NewLine + System.Environment.NewLine + "– Cecil Selig"));
            myQoutes.Add(new Qoutes123(63, "The day I see a leaf is a marvel of a day." + System.Environment.NewLine + System.Environment.NewLine + "– Kenneth Patton"));
            myQoutes.Add(new Qoutes123(64, "Twilight drops her curtain down, and pins it with a star." + System.Environment.NewLine + System.Environment.NewLine + "– Lucy Maud"));
            myQoutes.Add(new Qoutes123(65, "Study nature, love nature, stay close to nature. It will never fail you." + System.Environment.NewLine + System.Environment.NewLine + "– Frank Llyod"));
            myQoutes.Add(new Qoutes123(66, "The poetry of the earth is never dead.." + System.Environment.NewLine + System.Environment.NewLine + "– John Keats"));
            myQoutes.Add(new Qoutes123(67, "Nature will bear the closest inspection. She invites us to lay our eye level with her smallest leaf, and take an insect view of its plain." + System.Environment.NewLine + System.Environment.NewLine + "– Henry David"));
            myQoutes.Add(new Qoutes123(68, "Trees are the earth’s endless effort to speak to the listening heaven.." + System.Environment.NewLine + System.Environment.NewLine + "– Rabindranath Tagore"));
            myQoutes.Add(new Qoutes123(69, "To me a lush carpet of pine needles or spongy grass is more welcome than the most luxurious Persian rug." + System.Environment.NewLine + System.Environment.NewLine + " – Helen Keller"));
            myQoutes.Add(new Qoutes123(70, "All my life through, the new sights of Nature made me rejoice like a child." + System.Environment.NewLine + System.Environment.NewLine + "– Marie Curie"));
            myQoutes.Add(new Qoutes123(71, "My profession is to always find God in nature. " + System.Environment.NewLine + System.Environment.NewLine + "– Hans Hofmann"));
            myQoutes.Add(new Qoutes123(72, "Whoever loves and understands a garden will find contentment within." + System.Environment.NewLine + System.Environment.NewLine + "– RabindraNath Tagore"));
            myQoutes.Add(new Qoutes123(73, "When nature speaks, wise men listen."));
            myQoutes.Add(new Qoutes123(74, "Natures beauty soothe my eyes,Refreshes my soul,Helps in imagination..."));
            myQoutes.Add(new Qoutes123(75, "I love walking barefoot in the grass, it’s like freedom."));



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











        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/about.xaml", UriKind.Relative));
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

        private void image2_Copy_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            Clipboard.SetText(txtqoutes.Text);
            MessageBox.Show("Copied Successfully");
        }
    }
}