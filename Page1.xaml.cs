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
    public partial class Page1 : PhoneApplicationPage
    {

        SpeechSynthesizer synth;
        Random rand = new Random();
        public Page1()
        {
            InitializeComponent();
            ApplicationBar.IsVisible = false;
        }

        private void image1_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            textBlock1.Visibility = Visibility.Collapsed;

            P1.Visibility = Visibility.Visible;
            List<Qoutes123> myQoutes = new List<Qoutes123>();
            myQoutes.Add(new Qoutes123(1, "Power is not happiness. Security and peace are more to be desired than a man at which nations tremble." + System.Environment.NewLine + System.Environment.NewLine + "– Florence Griffith Joyner"));
            myQoutes.Add(new Qoutes123(2, "Apparently there is nothing that cannot happen today." + System.Environment.NewLine + System.Environment.NewLine + "– Mark Twain"));
            myQoutes.Add(new Qoutes123(3, "Trouble springs from idleness, and grievous toil from needless ease." + System.Environment.NewLine + System.Environment.NewLine + "– Benjamin Franklin"));
            myQoutes.Add(new Qoutes123(4, " Strive not to be a success, but rather to be of value." + System.Environment.NewLine + System.Environment.NewLine + "– Albert Einstein"));
            myQoutes.Add(new Qoutes123(5, "Scientists have proven that it’s impossible to long-jump 30 feet, but I don’t listen to that kind of talk. Thoughts like that have a way of sinking into your feet." + System.Environment.NewLine + System.Environment.NewLine + "– Carl Lewis"));
            myQoutes.Add(new Qoutes123(6, "Rapine, avarice, expense, this is idolatry; and these we adore; plan living and high thinking are no more." + System.Environment.NewLine + System.Environment.NewLine + "– William Wordsworth"));
            myQoutes.Add(new Qoutes123(7, "For pleasures past I do not grieve, nor perils gathering near; My greatest grief is that I leave nothing that claims a tear." + System.Environment.NewLine + System.Environment.NewLine + "– Lord Byron"));
            myQoutes.Add(new Qoutes123(8, "Write your injuries in dust, your benefits in marble." + System.Environment.NewLine + System.Environment.NewLine + "– Benjamin Franklin"));
            myQoutes.Add(new Qoutes123(9, "The great accomplishments of man have resulted from the transmission of ideas and enthusiasm." + System.Environment.NewLine + System.Environment.NewLine + "– Thomas J. Watson"));
            myQoutes.Add(new Qoutes123(10, "Sincerity and truth are the basis of every virtue." + System.Environment.NewLine + System.Environment.NewLine + "– Confucius"));
            myQoutes.Add(new Qoutes123(11, "The Ladder of success is never crowded at the top." + System.Environment.NewLine + System.Environment.NewLine + "– Napoleon Hill"));
            myQoutes.Add(new Qoutes123(12, "They come into being not through demonstration but through revelation, through the medium of powerful personalities." + System.Environment.NewLine + System.Environment.NewLine + "– Albert Einstein"));
            myQoutes.Add(new Qoutes123(13, "Harold like the rest of us, had many impressions which saved him the trouble of distinct ideas." + System.Environment.NewLine + System.Environment.NewLine + "– George Eliot"));
            myQoutes.Add(new Qoutes123(14, "On a level plain, simple mounds look like hills; and the insipid flatness of our present bourgeoisie is to be measured by the altitude of its great intellects" + System.Environment.NewLine + System.Environment.NewLine + "– Karl Marx"));
            myQoutes.Add(new Qoutes123(15, "The soul never thinks without a picture." + System.Environment.NewLine + System.Environment.NewLine + "– Aristotle"));
            myQoutes.Add(new Qoutes123(16, "It is best to be yourself, imperial, plain and true." + System.Environment.NewLine + System.Environment.NewLine + "– Robert Browning"));
            myQoutes.Add(new Qoutes123(17, "Always continue the climb. It is possible for you to do whatever you choose, if you first get to know who you are and are willing to work with a power that is greater than ourselves to do it. " + System.Environment.NewLine + System.Environment.NewLine + "– Oprah Winfrey"));
            myQoutes.Add(new Qoutes123(18, "I figured that if I said it enough, I would convince the world that I really was the greatest." + System.Environment.NewLine + System.Environment.NewLine + "– Muhammad Ali"));
            myQoutes.Add(new Qoutes123(19, "Whatever is begun in anger, ends in shame" + System.Environment.NewLine + System.Environment.NewLine + "– Benjamin Franklin"));
            myQoutes.Add(new Qoutes123(20, "You cannot shake hands with a clenched fist." + System.Environment.NewLine + System.Environment.NewLine + "– Indira Gandhi"));
            myQoutes.Add(new Qoutes123(21, "When angry, count four; when very angry, swear." + System.Environment.NewLine + System.Environment.NewLine + "– Mark Twain"));
            myQoutes.Add(new Qoutes123(22, "The purely agitation attitude is not good enough for a detailed consideration of a subject." + System.Environment.NewLine + System.Environment.NewLine + "– Jawaharlal Nehru"));
            myQoutes.Add(new Qoutes123(23, "If you don't ask, you don't get." + System.Environment.NewLine + System.Environment.NewLine + "– Mahatma Gandhi"));
            myQoutes.Add(new Qoutes123(24, "Our character is basically a composite of our habits. Because they are consistent,often unconcious patterns, they constantly, daily, express our character" + System.Environment.NewLine + System.Environment.NewLine + "– Stephen R. Covey"));
            myQoutes.Add(new Qoutes123(25, "Big jobs usually go to the men who prove their ability to outgrow small ones." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(26, "We should be too big to take offense and too noble to give it" + System.Environment.NewLine + System.Environment.NewLine + "– Abraham Lincoln"));
            myQoutes.Add(new Qoutes123(27, "It is not the strongest of the species that survive, nor the most intelligent, but the one must responsive to change." + System.Environment.NewLine + System.Environment.NewLine + "– Charles Darwin"));
            myQoutes.Add(new Qoutes123(28, "The only person that can ever truly make you happy is yourself. Stop depending on everyone else."));
            myQoutes.Add(new Qoutes123(29, "Want people to think you’re amazing? Start believing you are, and then they will too."));
            myQoutes.Add(new Qoutes123(30, "Smiling is the ultimate anti-depressant. Smile and laugh out loud, it doesn’t look stupid, I promise."));
            myQoutes.Add(new Qoutes123(31, "The world is never just black and white, right or wrong, one way or another. Try and see things from as many points of view as possible"));
            myQoutes.Add(new Qoutes123(32, "Let everything happen to youBeauty and terror Just keep going.No feeling is final" + System.Environment.NewLine + System.Environment.NewLine + "– Rainer Maria Rilke"));
            myQoutes.Add(new Qoutes123(33, "Gossip, problems of the past, events you cannot control, negative thoughts and negative people; time spent on these is time poorly wasted. "));
            myQoutes.Add(new Qoutes123(34, "When you're jealous or find yourself filled with hate for someone/something, stop. The only person its hurting is you."));
            myQoutes.Add(new Qoutes123(35, "Although the newest, most expensive material things may make you feel as if you’re a better person, they won’t hold you at night or listen to you when you need it. Make sure your priorities make sense."));
            myQoutes.Add(new Qoutes123(36, "Step outside your comfort zone- it’s when you’ll really feel alive"));
            myQoutes.Add(new Qoutes123(37, "Don’t be afraid to be yourself, the people who really matter, don’t mind"));
            myQoutes.Add(new Qoutes123(38, "Let your emotions out sometimes, humans have them for a reason. "));
            myQoutes.Add(new Qoutes123(39, "Celebrate the things you have. Think only positively of the things you don’t (but would like to have) and they too will come."));
            myQoutes.Add(new Qoutes123(40, "Happiness is excitement that has found a settling down place.  But there is always a little corner that keeps flapping around." + System.Environment.NewLine + System.Environment.NewLine + "– E.L. Konigsburg"));
            myQoutes.Add(new Qoutes123(41, "Man is fond of counting his troubles, but he does not count his joys.  If he counted them up as he ought to, he would see that every lot has enough happiness provided for it." + System.Environment.NewLine + System.Environment.NewLine + "– Fyodor Dostoevsky"));
            myQoutes.Add(new Qoutes123(42, "You must first be who you really are, then do what you need to do, in order to have what you want." + System.Environment.NewLine + System.Environment.NewLine + " – Margaret Young"));
            myQoutes.Add(new Qoutes123(43, "My advice to you is not to inquire why or whither, but just enjoy your ice cream while it’s on your plate. " + System.Environment.NewLine + System.Environment.NewLine + "– Thornton Wilder"));
            myQoutes.Add(new Qoutes123(44, "Enjoy the little things, for one day you may look back and realize they were the big things." + System.Environment.NewLine + System.Environment.NewLine + "– Robert Brault"));
            myQoutes.Add(new Qoutes123(45, "Happiness is when what you think, what you say, and what you do are in harmony." + System.Environment.NewLine + System.Environment.NewLine + "– Mahatma Gandhi"));
            myQoutes.Add(new Qoutes123(46, "All our dreams can come true, if we have the courage to pursue them." + System.Environment.NewLine + System.Environment.NewLine + "– Walt Disney"));
            myQoutes.Add(new Qoutes123(47, "The future belongs to those who believe in the beauty of their dreams." + System.Environment.NewLine + System.Environment.NewLine + "– Eleanor Roosevelt"));
            myQoutes.Add(new Qoutes123(48, "Every now and then go away and have a little relaxation.  To remain constantly at work will diminish your judgment.  Go some distance away, because work will be in perspective and a lack of harmony is more readily seen." + System.Environment.NewLine + System.Environment.NewLine + "– Leonardo DaVinci"));
            myQoutes.Add(new Qoutes123(49, "The path involves respect for all small and subtle things.  Learn to recognize the right moment to strike the necessary attitudes." + System.Environment.NewLine + System.Environment.NewLine + "– Manual of the Warrior of Light"));
            myQoutes.Add(new Qoutes123(50, "The thing that is really hard and really amazing is giving up on being perfect and beginning the work of becoming yourself." + System.Environment.NewLine + System.Environment.NewLine + "– Anna Quindlen"));
            myQoutes.Add(new Qoutes123(51, "You have brains in your head and feet in your shoes.  You can steer yourself any direction you choose.  You’re on your own and you know what you know.  And you are the one who’ll decide where to go." + System.Environment.NewLine + System.Environment.NewLine + "– Dr. Seuss"));
            myQoutes.Add(new Qoutes123(52, "I am unfolding in fulfilling ways.  Only good can come to me.  I now express health, happiness, prosperity, and peace of mind."));
            myQoutes.Add(new Qoutes123(53, "Know that joy is rarer, more difficult, and more beautiful than sadness.  Once you make this all-important discovery, you must embrace joy as a moral obligation." + System.Environment.NewLine + System.Environment.NewLine + "– Andre Gide"));
            myQoutes.Add(new Qoutes123(54, "Do not be too timid and squeamish about your actions all life is an experience." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(55, "If the future road loom ominous or unpromising, and the road back uninviting, then we need to gather our resolve and, carrying only the necessary baggage, step off that road into another direction." + System.Environment.NewLine + System.Environment.NewLine + "– Maya Angelou"));
            myQoutes.Add(new Qoutes123(56, "I rejoice in what I have and I know that fresh new experiences are always ahead.  I greet the new with open arms.  I trust life to be wonderful." + System.Environment.NewLine + System.Environment.NewLine + "– Louise Hay"));
            myQoutes.Add(new Qoutes123(57, "You must do the thing you think you cannot do." + System.Environment.NewLine + System.Environment.NewLine + "– Eleanor Roosevelt"));
            myQoutes.Add(new Qoutes123(58, "He is happiest, be he king or peasant, who finds peace in his home." + System.Environment.NewLine + System.Environment.NewLine + "– Johann von Goethe"));
            myQoutes.Add(new Qoutes123(59, "I may not have gone where I intended to go, but I think I’ve ended up where I needed to be." + System.Environment.NewLine + System.Environment.NewLine + "– Douglas Adams"));
            myQoutes.Add(new Qoutes123(60, "Conquering any difficulty always gives on a secret joy, for it means pushing back a boundary line and adding to one’s liberty." + System.Environment.NewLine + System.Environment.NewLine + "– Henri Frederic Amiel"));
            myQoutes.Add(new Qoutes123(61, "People are crying up the rich and variegated plumage of the peacock, and he is himself blushing at the sight of his ugly feet." + System.Environment.NewLine + System.Environment.NewLine + "– Sa’Di"));
            myQoutes.Add(new Qoutes123(62, "When the grass looks greener on the other side of the fence, it may be that they take better care of it there." + System.Environment.NewLine + System.Environment.NewLine + "– Cecil Selig"));
            myQoutes.Add(new Qoutes123(63, "A strong woman understands that the gifts such as logic, decisiveness, and strength are just as feminine as intuition and emotional connection.  She values and uses all of her gifts." + System.Environment.NewLine + System.Environment.NewLine + "– Nancy Rathburn"));
            myQoutes.Add(new Qoutes123(64, "It’s hard to fight an enemy who has outposts in your head." + System.Environment.NewLine + System.Environment.NewLine + "– Sally Kempton"));
            myQoutes.Add(new Qoutes123(65, "There are times to stay put, and what you want will come to you, and there are times to go out into the world and find such a thing for yourself." + System.Environment.NewLine + System.Environment.NewLine + "– Lemony Snicket"));
            myQoutes.Add(new Qoutes123(66, "A successful person is one who can lay a firm foundation with the bricks that others throw at her." + System.Environment.NewLine + System.Environment.NewLine + "– David Brinkley"));
            myQoutes.Add(new Qoutes123(67, "I focus my energy on my true intentions.  I will not be distracted by noise, chatter, or setbacks.  Patience, commitment, grace, and purpose will guide me." + System.Environment.NewLine + System.Environment.NewLine + "– Louise Hay"));
            myQoutes.Add(new Qoutes123(68, "You can’t be brave if you’ve only had wonderful things happen to you." + System.Environment.NewLine + System.Environment.NewLine + "– Mary Tyler Moore"));
            myQoutes.Add(new Qoutes123(69, "I breathe in the fullness and richness of life.  I observe with joy as life abundantly supports me and supplies me with more good than I can imagine." + System.Environment.NewLine + System.Environment.NewLine + " – Louise Hay"));
            myQoutes.Add(new Qoutes123(70, "Improve your spare moments and they will become the brightest gems in your life." + System.Environment.NewLine + System.Environment.NewLine + "– Ralph Waldo Emerson"));
            myQoutes.Add(new Qoutes123(71, "The ability to simplify means to eliminate the unnecessary so that the necessary may speak." + System.Environment.NewLine + System.Environment.NewLine + "– Hans Hofmann"));
            myQoutes.Add(new Qoutes123(72, "Success is a lousy teacher.  It seduces smart people into thinking they can’t lose." + System.Environment.NewLine + System.Environment.NewLine + "– Bill Gates"));
            myQoutes.Add(new Qoutes123(73, "I've learned that people will forget what you said, people will forget what you did, but people will never forget how you made them feel."));
            myQoutes.Add(new Qoutes123(74, "AdJusT youRSElf beCominG tHe pErson yOu moStlY pRoud tO be Who You thInK ReAlly hAs tHe bEst PlAce iN yOu bY beIng inDiffereNt amonG aLL thE reGreTs aNd FailUreS WhiCh WilL be The fRaGrance Of yOur FutuRe BleSSings"));
            myQoutes.Add(new Qoutes123(75, "Even the bad experiences can be learned from. In fact, they are probably the most poignant and important ones."));
            myQoutes.Add(new Qoutes123(76, "You can make of your life anything you wish. Create your own life then go out and live it with absolutely no regrets."));
            myQoutes.Add(new Qoutes123(77, "results are reasons, no matter how inadvertent. for every action there is an equal and opposite reaction. choosing to ignore this fact doesnt change it. it only makes you ignorant. and selfish. your actions affect others too."));
            myQoutes.Add(new Qoutes123(78, "Intellectual growth should commence at birth and cease only at death." + System.Environment.NewLine + System.Environment.NewLine + "– Albert Einstein"));
            myQoutes.Add(new Qoutes123(79, "Its hard to hold on to something that you know would never be yours in any way you think of. You just have to learn to let go and face the fact that while good things never last, some don't even start."));
            myQoutes.Add(new Qoutes123(80, "In this world we have to take chances, sometimes they're worth it and sometimes they're not, but I'm telling you now, you will never know until you try."));
            myQoutes.Add(new Qoutes123(81, "God wants us to live like the grass. Even if it's stepped on, crushed, burned and cut; it always persists and grows back even greener and stronger."));
            myQoutes.Add(new Qoutes123(82, "You deserve to wear a smile in your heart. Not because of what you have or what you do, but because of who you are. Yes, you are changing each day; but you are always amazing just as you are."));
            myQoutes.Add(new Qoutes123(83, "Success isn't just about what you accomplish in your life it's about what you inspire others to do."));
            myQoutes.Add(new Qoutes123(84, "Each of us represents a star in heaven. Sometimes we shine with the rest, sometimes we twinkle alone, and sometimes, when we least expect it, we make someone's dreams come true."));
            myQoutes.Add(new Qoutes123(85, "Before you talk, listen. Before you react, think. Before you criticize, wait. Before you pray, forgive. Before you quit, try."));
            myQoutes.Add(new Qoutes123(86, "When you finally let go of the past, something better comes along."));
            myQoutes.Add(new Qoutes123(87, "It is the Rule of Life that everything you have always wanted comes the very second you stop looking for it"));
            myQoutes.Add(new Qoutes123(88, "Move On.It's just a chapter in the past.But don't close the book , just turn the page"));
            myQoutes.Add(new Qoutes123(89, "I have heard there are troubles of more than one kind. Some come from ahead and some come from behind. But I’ve bought a big bat. I’m all ready you see. Now my troubles are going to have troubles with me" + System.Environment.NewLine + System.Environment.NewLine + "– Dr.Seuss"));
            myQoutes.Add(new Qoutes123(90, "Our greatest glory is not in never Falling, but in Falling everytime we fall"));
            myQoutes.Add(new Qoutes123(91, "There is no reality except the one contained within us.Thats why so many people live unreal life.They take images outside them for reality and never allow the world within them to assert itself"));
            myQoutes.Add(new Qoutes123(92, "Difficulties strengthen the mind,as labor does the body." + System.Environment.NewLine + System.Environment.NewLine + "– Seneca"));
            myQoutes.Add(new Qoutes123(93, "Throughout life you will meet one person who is unlike any other. This person is one you could forever talk to. They understand you in a way that no one else does or even could. This person is your soul mate, your best friend. Don’t ever let them go, for they’re your guardian angel sent from heaven above."));
            myQoutes.Add(new Qoutes123(94, "Love is as much of an object as an obsession, everybody wants it, everybody seeks it, but few ever achieve it, those who do will cherish it, be lost in it, and among all, never, never forget it."));
            myQoutes.Add(new Qoutes123(95, "I believe that two people are connected at the heart & it doesn’t matter what you do,or who you are, or where you live, there are no boundaries or barriers. If two people are destined to be together, they will be."));
            myQoutes.Add(new Qoutes123(96, "Love isn’t just laughing and having fun together. It’s not about being stupid together. Love is more than just all that little stuff. It’s doing everything together, and having the time of your life; and never wanting to end it."));
            myQoutes.Add(new Qoutes123(97, "Everyone says love hurts, but that is not true. Loneliness hurts. Rejection hurts. Losing someone hurts. Envy hurts. Everyone gets these things confused with love. But in reality love is the only thing in this world that covers up all pain and makes someone feel wonderful again."));
            myQoutes.Add(new Qoutes123(98, "Your work is to discover your work and then with all your heart to give yourself to it." + System.Environment.NewLine + System.Environment.NewLine + "– Buddha"));
            myQoutes.Add(new Qoutes123(99, "To keep the body in good health is a duty…otherwise we shall not be able to keep our mind strong and clear." + System.Environment.NewLine + System.Environment.NewLine + "– Buddha"));
            myQoutes.Add(new Qoutes123(100, "In the sky, there is no distinction of east and west; people create distinctions out of their own minds and then believe them to be true." + System.Environment.NewLine + System.Environment.NewLine + "– Buddha"));

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

       




        private void share(object sender, EventArgs e)
        {
            ShareLinkTask shareLinkTask = new ShareLinkTask();
            shareLinkTask.Title = "Download Quotes and Sayings";
            shareLinkTask.LinkUri = new Uri("http://www.windowsphone.com/s?appid=6b8bd2f1-0391-4ba0-a7f6-9825b3d0dbff", UriKind.Absolute);   //Change this appid only
            shareLinkTask.Message = "A creative application to learn and come through famous quotes and sayings";

            shareLinkTask.Show();
        }

        private void rateme(object sender, EventArgs e)
        {

            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }

        private void feedback(object sender, EventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            emailComposeTask.Subject = "Feedback to App";           //message subject
            emailComposeTask.Body = "Write your feedback here...";  //message body
            emailComposeTask.To = "vinaymatt@outlook.com";          //email id
            emailComposeTask.Show();
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
    }
}