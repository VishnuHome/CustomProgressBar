using System.Windows;
using System.Windows.Controls;

namespace NetEti.CustomControls
{
    /// <summary>
    /// Stellt eine ProgressBar mit zusätzlichen Eigenschaften zur Verfügung:
    /// abschaltbarer glow-Effekt, wählbare Farbe, zentrierter Zusatztext.
    /// </summary>
    /// <remarks>
    /// File: CustomProgressBar.xaml.cs<br></br>
    /// Autor: Erik Nagel, NetEti<br></br>
    ///<br></br>
    /// 21.01.2013 Erik Nagel: erstellt<br></br>
    /// </remarks>
    public partial class CustomProgressBar : UserControl
    {
        /// <summary>
        /// Prozentwert der ProgressBar - kann von außen gelesen und gesetzt werden.
        /// </summary>
        public static DependencyProperty ValueProperty = DependencyProperty.RegisterAttached("Value", typeof(int), typeof(CustomProgressBar));
        /// <summary>
        /// Prozentwert der ProgressBar - kann von außen gelesen und gesetzt werden.
        /// </summary>
        public int Value
        {
            get
            {
                return (int)GetValue(ValueProperty);
            }
            set
            {
                SetValue(ValueProperty, value);
            }
        }

        /// <summary>
        /// Schaltet zwischen von links nach rechts laufender und ewig hin und her laufender ProgressBar um.
        /// </summary>
        public static DependencyProperty IsIndeterminateProperty = DependencyProperty.RegisterAttached("IsIndeterminate", typeof(bool), typeof(CustomProgressBar));
        /// <summary>
        /// Schaltet zwischen von links nach rechts laufender und ewig hin und her laufender ProgressBar um.
        /// </summary>
        public bool IsIndeterminate
        {
            get
            {
                return (bool)GetValue(IsIndeterminateProperty);
            }
            set
            {
                SetValue(IsIndeterminateProperty, value);
            }
        }

        /// <summary>
        /// Schaltet den Glow-Effekt der ProgressBar an oder aus.
        /// </summary>
        public static DependencyProperty IsGlowingProperty = DependencyProperty.RegisterAttached("IsGlowing", typeof(bool), typeof(CustomProgressBar));
        /// <summary>
        /// Schaltet den Glow-Effekt der ProgressBar an oder aus.
        /// </summary>
        public bool IsGlowing
        {
            get
            {
                return (bool)GetValue(IsGlowingProperty);
            }
            set
            {
                SetValue(IsGlowingProperty, value);
            }
        }

        /// <summary>
        /// Setzt oder liest einen auf der ProgressBar zentrierten Zusatztext.
        /// </summary>
        public static DependencyProperty TextProperty = DependencyProperty.RegisterAttached("Text", typeof(string), typeof(CustomProgressBar));
        /// <summary>
        /// Setzt oder liest einen auf der ProgressBar zentrierten Zusatztext.
        /// </summary>
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        /*
        public static DependencyProperty ForegroundProperty 
          = DependencyProperty.RegisterAttached("Foreground", typeof(Color), typeof(CustomProgressBar),
              new FrameworkPropertyMetadata(
                  Colors.Green, 
                  FrameworkPropertyMetadataOptions.AffectsRender,
                  CallBackWhenBarColorPropertyIsChanged)
            );


        // Called when property is changed
        private static void CallBackWhenBarColorPropertyIsChanged(
         object sender,
         DependencyPropertyChangedEventArgs args)
        {
          //var attachedObject = sender as UserControl;
          //if (attachedObject != null)
          //{
          //  //Logger.Log(GetHasParent(attachedObject).ToString());
          //  // do whatever is necessary, for example
          //  // attachedObject.CallSomeMethod( 
          //  // args.NewValue as TargetPropertyType);
          //}
        }

        public Color Foreground
        {
          get
          {
            return (Color)GetValue(ForegroundProperty);
          }
          set
          {
            SetValue(ForegroundProperty, value);
          }
        }
        */

        /// <summary>
        /// Standard-Konstruktor.
        /// </summary>
        public CustomProgressBar()
        {
            InitializeComponent();
        }
    }
}
