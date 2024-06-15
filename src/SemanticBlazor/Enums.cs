﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace SemanticBlazor
{
  public class Enums
  {
    public static string GetClass<T>(T enumValue)
    {
      return (enumValue ?? (object) "").ToString().ToLower().Replace("_", " ");
    }

    public static string GetClasses<T>(T[] values)
    {
      if (values != null)
      {
        return string.Join(" ", values?.Select(v => GetClass(v)));
      }
      else
      {
        return null;
      }
    }
  }

  #region Colors

  public enum Color
  {
    Red,
    Orange,
    Yellow,
    Olive,
    Green,
    Teal,
    Blue,
    Violet,
    Purple,
    Pink,
    Brown,
    Grey,
    Black
  }
  public enum ButtonColor
  {
    Positive,
    Negative,
    Red,
    Orange,
    Yellow,
    Olive,
    Green,
    Teal,
    Blue,
    Violet,
    Purple,
    Pink,
    Brown,
    Grey,
    Black
  }
  public enum MessageColor
  {
    Info,
    Positive,
    Warning,
    Negative,
    Red,
    Orange,
    Yellow,
    Olive,
    Green,
    Teal,
    Blue,
    Violet,
    Purple,
    Pink,
    Brown,
    Grey,
    Black
  }

  public enum HeaderColor
  {
    Red,
    Orange,
    Yellow,
    Olive,
    Green,
    Teal,
    Blue,
    Violet,
    Purple,
    Pink,
    Brown,
    Grey,
    Black
  }
  #endregion

  #region Sizes

  public enum Size
  {
    Mini,
    Tiny,
    Small,
    Medium,
    Large,
    Big,
    Huge,
    Massive
  }
  public enum InputSize
  {
    Mini,
    Small,
    Large,
    Big,
    Huge,
    Massive
  }
  public enum ModalSize
  {
    Mini,
    Tiny,
    Small,
    Large,
    Fullscreen
  }

  public enum HeaderSize
  {
    Tiny,
    Small,
    Medium,
    Large,
    Huge
  }

  #endregion

  public enum State
  {
    Success,
    Error,
    Warning
  }
  public enum Emphasis
  {
    Primary,
    Secondary,
    Tertiary
  }

  #region Additional classes

  public enum SegmentClass
  {
    Basic,
    Raised,
    Stacked,
    Piled,
    Compact,
    Circular,
    Clearing,
    Loading,
    Placeholder,
    Vertical,
    Inverted,
    Top_Attached,
    Bottom_Attached,
    Padded,
    Very_Padded,
    Right_Floated,
    Left_Floated,
    Right_Aligned,
    Left_Aligned,
    Center_Aligned
  }
  public enum ButtonClass
  {
    Animated,
    Labeled,
    Icon,
    Basic,
    Inverted,
    Right_Floated,
    Left_Floated,
    Compact,
    Toggle,
    Fluid,
    Circular,
    Top_Attached,
    Bottom_Attached,
    Left_Attached,
    Right_Attached
  }
  public enum GridClass
  {
    Relaxed,
    Very_Relaxed,
    Celled,
    Internally_Celled,
    Equal_Width,
    Centered,
    Right_Aligned,
    Left_Aligned,
    Center_Aligned,
    Stackable,
    Mobile_Reversed
  }
  public enum GridUnit
  {
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Eleven,
    Twelve,
    Thirteen,
    Fourteen,
    Fifteen,
    Sixteen
  }
  public enum ColumnClass
  {
    Right_Floated,
    Left_Floated,
    Right_Aligned,
    Left_Aligned,
    Center_Aligned,
    Doubling
  }
  public enum DividerClass
  {
    Horizontal,
    Vertical,
    Inverted,
    Fitted,
    Hidden,
    Clearing
  }
  public enum IconClass
  {
    Loading,
    Fitted,
    Flipped,
    Rotated,
    Circular,
    Bordered,
    Inverted
  }
  public enum InputClass
  {
    Transparent,
    Inverted,
    Fluid,
    Labeled
  }
  public enum LabelClass
  {
    Basic,
    Empty,
    Horizontal,
    Floating,
    Image,
    Right,
    Left,
    Top_Attached,
    Bottom_Attached,
    Circular,
    Pointing,
    Pointing_Below,
    Corner,
    Tag,
    Ribbon
  }
  public enum MessageClass
  {
    Floating,
    Compact,
    Top_Attached,
    Bottom_Attached
  }
  public enum MenuClass
  {
    Secondary,
    Compact,
    Pointing,
    Text,
    Vertical,
    Fluid,
    Pagination,
    Tabular,
    Fixed,
    Stackable,
    Inverted,
    Top_Attached,
    Bottom_Attached,
    Fitted,
    Borderless
  }
  public enum FormClass
  {
    Loading,
    Equal_Width,
    Inverted
  }
  public enum FieldsClass
  {
    Equal_Width,
    Inline
  }
  public enum FieldClass
  {
    Inline
  }

  public enum HeaderClass
  {
    Dividing,
    Block,
    Top,
    Attached,
    Bottom,
    Left,
    Right,
    Floated,
    Aligned,
    Justified,
    Inverted
  }

  #endregion

  public enum IconPosition
  {
    Right,
    Left
  }
  public enum ValidationPosition
  {
    Hidden,
    Top,
    Bottom
  }
  public enum TabMenuPosition
  {
    Top,
    Bottom
  }
  public enum CheckboxType
  {
    Checkbox,
    Slider,
    Toggle
  }
  public enum ListViewType
  {
    List,
    Items,
    Comments,
    Feed,
    Cards,
    Custom
  }
  public enum DropdownAction
  {
    Auto,
    Activate,
    Select,
    Combo,
    Hide,
    Nothing
  }
  public enum DropdownOn
  {
    Click,
    Hover
  }

  public enum DropdownFulltextSearch
  {
    True,
    False,
    Exact
  }

  public enum TimePrecision
  {
    Hour,
    Minute,
    //Second
  }

  public enum ModalCloseIcon
  {
    Outside,
    Inside,
    None
  }

  public class Icons
  {
    public static string GetClass(Icon? icon)
    {
      return icon.HasValue ? icon.ToString().ToLower().Replace("_", " ") : "";
    }

    public static string GetClass(Icon icon)
    {
      return icon.ToString().ToLower().Replace("_", " ");
    }
  }
  public enum Icon
  {
    //Loading
    Spinner_Loading,
    Notched_Circle_Loading,
    Asterisk_Loading,
    Sync_Loading,
    Sync_Alternate_Loading,
    Certificate_Loading,
    Cog_Loading,
    Compass_Loading,
    Compass_Outline_Loading,
    Crosshairs_Loading,
    Life_Ring_Loading,
    Life_Ring_Outline_Loading,
    Snowflake_Loading,
    Snowflake_Outline_Loading,
    Sun_Loading,
    Sun_Outline_Loading,

    //All icons
    Accessible_Icon,
    Accusoft,
    Address_Book,
    Address_Book_Outline,
    Address_Card,
    Address_Card_Outline,
    Adjust,
    Adn,
    Adversal,
    Affiliatetheme,
    Algolia,
    Align_Center,
    Align_Justify,
    Align_Left,
    Align_Right,
    Amazon,
    Amazon_Pay,
    Ambulance,
    American_Sign_Language_Interpreting,
    Amilia,
    Android,
    Angellist,
    Angle_Double_Down,
    Angle_Double_Left,
    Angle_Double_Right,
    Angle_Double_Up,
    Angle_Down,
    Angle_Left,
    Angle_Right,
    Angle_Up,
    Angrycreative,
    Angular,
    Anchor,
    App_Store,
    App_Store_Ios,
    Apper,
    Apple,
    Apple_Pay,
    Archive,
    Arrow_Alternate_Circle_Down,
    Arrow_Alternate_Circle_Down_Outline,
    Arrow_Alternate_Circle_Left,
    Arrow_Alternate_Circle_Left_Outline,
    Arrow_Alternate_Circle_Right,
    Arrow_Alternate_Circle_Right_Outline,
    Arrow_Alternate_Circle_Up,
    Arrow_Alternate_Circle_Up_Outline,
    Arrow_Circle_Down,
    Arrow_Circle_Left,
    Arrow_Circle_Right,
    Arrow_Circle_Up,
    Arrow_Down,
    Arrow_Left,
    Arrow_Right,
    Arrow_Up,
    Arrows_Alternate,
    Arrows_Alternate_Horizontal,
    Arrows_Alternate_Vertical,
    Assistive_Listening_Systems,
    Asterisk,
    Asymmetrik,
    At,
    Audible,
    Audio_Description,
    Autoprefixer,
    Avianex,
    Aviato,
    Aws,
    Backward,
    Balance_Scale,
    Ban,
    Band_Aid,
    Bandcamp,
    Barcode,
    Bars,
    Baseball_Ball,
    Basketball_Ball,
    Bath,
    Battery_Empty,
    Battery_Full,
    Battery_Half,
    Battery_Quarter,
    Battery_Three_Quarters,
    Bed,
    Beer,
    Behance,
    Behance_Square,
    Bell,
    Bell_Outline,
    Bell_Slash,
    Bell_Slash_Outline,
    Bicycle,
    Bimobject,
    Binoculars,
    Birthday_Cake,
    Bitbucket,
    Bitcoin,
    Bity,
    Black_Tie,
    Blackberry,
    Blind,
    Blogger,
    Blogger_B,
    Bluetooth,
    Bluetooth_B,
    Bold,
    Bolt,
    Bomb,
    Book,
    Bookmark,
    Bookmark_Outline,
    Bowling_Ball,
    Box,
    Boxes,
    Braille,
    Briefcase,
    Btc,
    Bug,
    Building,
    Building_Outline,
    Bullhorn,
    Bullseye,
    Buromobelexperte,
    Bus,
    Business,
    Buysellads,
    Calculator,
    Calendar,
    Calendar_Alternate,
    Calendar_Alternate_Outline,
    Calendar_Check,
    Calendar_Check_Outline,
    Calendar_Minus,
    Calendar_Minus_Outline,
    Calendar_Outline,
    Calendar_Plus,
    Calendar_Plus_Outline,
    Calendar_Times,
    Calendar_Times_Outline,
    Camera,
    Camera_Retro,
    Car,
    Caret_Down,
    Caret_Left,
    Caret_Right,
    Caret_Square_Down,
    Caret_Square_Down_Outline,
    Caret_Square_Left,
    Caret_Square_Left_Outline,
    Caret_Square_Right,
    Caret_Square_Right_Outline,
    Caret_Square_Up,
    Caret_Square_Up_Outline,
    Caret_Up,
    Cart_Arrow_Down,
    Cart_Plus,
    Cc_Amazon_Pay,
    Cc_Amex,
    Cc_Apple_Pay,
    Cc_Diners_Club,
    Cc_Discover,
    Cc_Jcb,
    Cc_Mastercard,
    Cc_Paypal,
    Cc_Stripe,
    Cc_Visa,
    Centercode,
    Certificate,
    Circle,
    Circle_Notch,
    Circle_Outline,
    Clipboard,
    Clipboard_Check,
    Clipboard_List,
    Clipboard_Outline,
    Clock,
    Clock_Outline,
    Clone,
    Clone_Outline,
    Close_Icon,
    Closed_Captioning,
    Closed_Captioning_Outline,
    Cloud,
    Cloud_Download,
    Cloud_Upload,
    Cloudscale,
    Cloudsmith,
    Cloudversify,
    Code,
    Code_Branch,
    Codepen,
    Codiepie,
    Coffee,
    Cog,
    Cogs,
    Columns,
    Comment,
    Comment_Alternate,
    Comment_Alternate_Outline,
    Comment_Outline,
    Comments,
    Comments_Outline,
    Compass,
    Compass_Outline,
    Compress,
    Connectdevelop,
    Contao,
    Copy,
    Copy_Outline,
    Copyright,
    Copyright_Outline,
    Cpanel,
    Creative_Commons,
    Credit_Card,
    Credit_Card_Outline,
    Crop,
    Crosshairs,
    Css3,
    Css3_Alternate,
    Cube,
    Cubes,
    Currency,
    Cut,
    Cuttlefish,
    D_And_D,
    Dashcube,
    Database,
    Deaf,
    Delicious,
    Deploydog,
    Deskpro,
    Desktop,
    Deviantart,
    Digg,
    Digital_Ocean,
    Discord,
    Discourse,
    Dna,
    Docker,
    Dochub,
    Dollar_Sign,
    Dolly,
    Dolly_Flatbed,
    Dot_Circle,
    Dot_Circle_Outline,
    Download,
    Draft2Digital,
    Dribbble,
    Dribbble_Square,
    Dropbox,
    Drupal,
    Dyalog,
    Earlybirds,
    Edge,
    Edit,
    Edit_Outline,
    Eject,
    Elementor,
    Ellipsis_Horizontal,
    Ellipsis_Vertical,
    Ember,
    Empire,
    Envelope,
    Envelope_Open,
    Envelope_Open_Outline,
    Envelope_Outline,
    Envelope_Square,
    Envira,
    Eraser,
    Erlang,
    Ethereum,
    Etsy,
    Euro_Sign,
    Exclamation,
    Exclamation_Circle,
    Exclamation_Triangle,
    Exchange,
    Expand,
    Expand_Arrows_Alternate,
    Expeditedssl,
    External_Alternate,
    External_Square_Alternate,
    Eye,
    Eye_Dropper,
    Eye_Slash,
    Eye_Slash_Outline,
    Facebook,
    Facebook_F,
    Facebook_Messenger,
    Facebook_Square,
    Fast_Backward,
    Fast_Forward,
    Fax,
    Female,
    Fighter_Jet,
    File,
    File_Alternate,
    File_Alternate_Outline,
    File_Archive,
    File_Archive_Outline,
    File_Audio,
    File_Audio_Outline,
    File_Code,
    File_Code_Outline,
    File_Excel,
    File_Excel_Outline,
    File_Image,
    File_Image_Outline,
    File_Outline,
    File_Pdf,
    File_Pdf_Outline,
    File_Powerpoint,
    File_Powerpoint_Outline,
    File_Video,
    File_Video_Outline,
    File_Word,
    File_Word_Outline,
    Film,
    Filter,
    Fire,
    Fire_Extinguisher,
    Firefox,
    First_Aid,
    First_Order,
    Firstdraft,
    Flag,
    Flag_Checkered,
    Flag_Outline,
    Flask,
    Flickr,
    Flipboard,
    Fly,
    Folder,
    Folder_Open,
    Folder_Open_Outline,
    Folder_Outline,
    Font,
    Font_Awesome,
    Font_Awesome_Alternate,
    Font_Awesome_Flag,
    Fonticons,
    Fonticons_Fi,
    Football_Ball,
    Fort_Awesome,
    Fort_Awesome_Alternate,
    Forumbee,
    Forward,
    Foursquare,
    Free_Code_Camp,
    Freebsd,
    Frown,
    Frown_Outline,
    Futbol,
    Futbol_Outline,
    Gamepad,
    Gavel,
    Gem,
    Gem_Outline,
    Genderless,
    Genders,
    Get_Pocket,
    Gg,
    Gg_Circle,
    Gift,
    Git,
    Git_Square,
    Github,
    Github_Alternate,
    Github_Square,
    Gitkraken,
    Gitlab,
    Gitter,
    Glass_Martini,
    Glide,
    Glide_G,
    Globe,
    Gofore,
    Golf_Ball,
    Goodreads,
    Goodreads_G,
    Google,
    Google_Drive,
    Google_Play,
    Google_Plus,
    Google_Plus_G,
    Google_Plus_Square,
    Google_Wallet,
    Graduation_Cap,
    Gratipay,
    Grav,
    Gripfire,
    Grunt,
    Gulp,
    H_Square,
    Hacker_News,
    Hacker_News_Square,
    Hand_Lizard,
    Hand_Lizard_Outline,
    Hand_Paper,
    Hand_Paper_Outline,
    Hand_Peace,
    Hand_Peace_Outline,
    Hand_Point_Down,
    Hand_Point_Down_Outline,
    Hand_Point_Left,
    Hand_Point_Left_Outline,
    Hand_Point_Right,
    Hand_Point_Right_Outline,
    Hand_Point_Up,
    Hand_Point_Up_Outline,
    Hand_Pointer,
    Hand_Pointer_Outline,
    Hand_Rock,
    Hand_Rock_Outline,
    Hand_Scissors,
    Hand_Scissors_Outline,
    Hand_Spock,
    Hand_Spock_Outline,
    Handshake,
    Handshake_Outline,
    Hashtag,
    Hdd,
    Hdd_Outline,
    Heading,
    Headphones,
    Health,
    Heart,
    Heart_Outline,
    Heartbeat,
    Hips,
    Hire_A_Helper,
    History,
    Hockey_Puck,
    Home,
    Hooli,
    Hospital,
    Hospital_Outline,
    Hospital_Symbol,
    Hotjar,
    Hourglass,
    Hourglass_End,
    Hourglass_Half,
    Hourglass_Outline,
    Hourglass_Start,
    Houzz,
    Html5,
    Hubspot,
    Chart_Area,
    Chart_Bar,
    Chart_Bar_Outline,
    Chart_Line,
    Chart_Pie,
    Check,
    Check_Circle,
    Check_Circle_Outline,
    Check_Square,
    Check_Square_Outline,
    Chess,
    Chess_Bishop,
    Chess_Board,
    Chess_King,
    Chess_Knight,
    Chess_Pawn,
    Chess_Queen,
    Chess_Rook,
    Chevron_Circle_Down,
    Chevron_Circle_Left,
    Chevron_Circle_Right,
    Chevron_Circle_Up,
    Chevron_Down,
    Chevron_Left,
    Chevron_Right,
    Chevron_Up,
    Child,
    Chrome,
    I_Cursor,
    Id_Badge,
    Id_Badge_Outline,
    Id_Card,
    Id_Card_Outline,
    Image,
    Image_Outline,
    Images,
    Images_Outline,
    Imdb,
    Inbox,
    Indent,
    Industry,
    Info,
    Info_Circle,
    Instagram,
    Internet_Explorer,
    Ioxhost,
    Italic,
    Itunes,
    Itunes_Note,
    Jenkins,
    Joget,
    Joomla,
    Js,
    Js_Square,
    Jsfiddle,
    Key,
    Keyboard,
    Keyboard_Outline,
    Keycdn,
    Kickstarter,
    Kickstarter_K,
    Korvue,
    Language,
    Laptop,
    Laravel,
    Lastfm,
    Lastfm_Square,
    Leaf,
    Leanpub,
    Lemon,
    Lemon_Outline,
    Less,
    Level_Down_Alternate,
    Level_Up_Alternate,
    Life_Ring,
    Life_Ring_Outline,
    Lightbulb,
    Lightbulb_Outline,
    Linechat,
    Linkedin,
    Linkedin_Alternate,
    Linkify,
    Linode,
    Linux,
    Lira_Sign,
    List,
    List_Alternate,
    List_Alternate_Outline,
    List_Ol,
    List_Ul,
    Location_Arrow,
    Lock,
    Lock_Open,
    Long_Arrow_Alternate_Down,
    Long_Arrow_Alternate_Left,
    Long_Arrow_Alternate_Right,
    Long_Arrow_Alternate_Up,
    Low_Vision,
    Lyft,
    Magento,
    Magic,
    Magnet,
    Male,
    Map,
    Map_Marker,
    Map_Marker_Alternate,
    Map_Outline,
    Map_Pin,
    Map_Signs,
    Mars,
    Mars_Double,
    Mars_Stroke,
    Mars_Stroke_Horizontal,
    Mars_Stroke_Vertical,
    Maxcdn,
    Medapps,
    Medium,
    Medium_M,
    Medkit,
    Medrt,
    Meetup,
    Meh,
    Meh_Outline,
    Mercury,
    Microchip,
    Microphone,
    Microphone_Slash,
    Microsoft,
    Minus,
    Minus_Circle,
    Minus_Square,
    Minus_Square_Outline,
    Mix,
    Mixcloud,
    Mizuni,
    Mobile,
    Mobile_Alternate,
    Modx,
    Monero,
    Money_Bill_Alternate,
    Money_Bill_Alternate_Outline,
    Moon,
    Moon_Outline,
    Motorcycle,
    Mouse_Pointer,
    Music,
    Napster,
    Neuter,
    Newspaper,
    Newspaper_Outline,
    Nintendo_Switch,
    Node,
    Node_Js,
    Npm,
    Ns8,
    Nutritionix,
    Object_Group,
    Object_Group_Outline,
    Object_Ungroup,
    Object_Ungroup_Outline,
    Odnoklassniki,
    Odnoklassniki_Square,
    Opencart,
    Openid,
    Opera,
    Optin_Monster,
    Osi,
    Outdent,
    Page4,
    Pagelines,
    Paint_Brush,
    Palfed,
    Pallet,
    Paper_Plane,
    Paper_Plane_Outline,
    Paperclip,
    Paragraph,
    Paste,
    Patreon,
    Pause,
    Pause_Circle,
    Pause_Circle_Outline,
    Paw,
    Paypal,
    Pen_Square,
    Pencil_Alternate,
    Percent,
    Periscope,
    Phabricator,
    Phoenix_Framework,
    Phone,
    Phone_Square,
    Phone_Volume,
    Php,
    Pied_Piper,
    Pied_Piper_Alternate,
    Pied_Piper_Pp,
    Pills,
    Pinterest,
    Pinterest_P,
    Pinterest_Square,
    Plane,
    Play,
    Play_Circle,
    Play_Circle_Outline,
    Playstation,
    Plug,
    Plus,
    Plus_Circle,
    Plus_Square,
    Plus_Square_Outline,
    Podcast,
    Pound_Sign,
    Power_Off,
    Print,
    Product_Hunt,
    Pushed,
    Puzzle_Piece,
    Python,
    Qq,
    Qrcode,
    Question,
    Question_Circle,
    Question_Circle_Outline,
    Quidditch,
    Quinscape,
    Quora,
    Quote_Left,
    Quote_Right,
    Random,
    Ravelry,
    React,
    Rebel,
    Recycle,
    Reddit,
    Reddit_Alien,
    Reddit_Square,
    Redo,
    Redo_Alternate,
    Redriver,
    Registered,
    Registered_Outline,
    Rendact,
    Renren,
    Reply,
    Reply_All,
    Replyd,
    Resolving,
    Retweet,
    Road,
    Rocket,
    Rocketchat,
    Rockrms,
    Rss,
    Rss_Square,
    Ruble_Sign,
    Rupee_Sign,
    Safari,
    Sass,
    Save,
    Save_Outline,
    Scribd,
    Search,
    Search_Minus,
    Search_Plus,
    Searchengin,
    Sellcast,
    Sellsy,
    Server,
    Servicestack,
    Share,
    Share_Alternate,
    Share_Alternate_Square,
    Share_Square,
    Share_Square_Outline,
    Shekel_Sign,
    Shield_Alternate,
    Ship,
    Shipping_Fast,
    Shirtsinbulk,
    Shopping_Bag,
    Shopping_Basket,
    Shopping_Cart,
    Shower,
    Schlix,
    Sign_In_Alternate,
    Sign_Language,
    Sign_Out_Alternate,
    Sign_In,
    Sign_Out,
    Signal,
    Simplybuilt,
    Sistrix,
    Sitemap,
    Skyatlas,
    Skype,
    Slack,
    Slack_Hash,
    Sliders_Horizontal,
    Slideshare,
    Smile,
    Smile_Outline,
    Snapchat,
    Snapchat_Ghost,
    Snapchat_Square,
    Snowflake,
    Snowflake_Outline,
    Sort,
    Sort_Alphabet_Down,
    Sort_Alphabet_Up,
    Sort_Amount_Down,
    Sort_Amount_Up,
    Sort_Down,
    Sort_Numeric_Down,
    Sort_Numeric_Up,
    Sort_Up,
    Soundcloud,
    Space_Shuttle,
    Speakap,
    Spinner,
    Spotify,
    Square,
    Square_Full,
    Square_Outline,
    Stack_Exchange,
    Stack_Overflow,
    Star,
    Star_Half,
    Star_Half_Outline,
    Star_Outline,
    Staylinked,
    Steam,
    Steam_Square,
    Steam_Symbol,
    Step_Backward,
    Step_Forward,
    Stethoscope,
    Sticker_Mule,
    Sticky_Note,
    Sticky_Note_Outline,
    Stop,
    Stop_Circle,
    Stop_Circle_Outline,
    Stopwatch,
    Strava,
    Street_View,
    Strikethrough,
    Stripe,
    Stripe_S,
    Studiovinari,
    Stumbleupon,
    Stumbleupon_Circle,
    Subscript,
    Subway,
    Suitcase,
    Sun,
    Sun_Outline,
    Superpowers,
    Superscript,
    Supple,
    Sync,
    Sync_Alternate,
    Syringe,
    Table,
    Table_Tennis,
    Tablet,
    Tablet_Alternate,
    Tag,
    Tags,
    Tachometer_Alternate,
    Tasks,
    Taxi,
    Telegram,
    Telegram_Plane,
    Tencent_Weibo,
    Terminal,
    Text_Height,
    Text_Width,
    Th,
    Th_Large,
    Th_List,
    Themeisle,
    Thermometer,
    Thermometer_Empty,
    Thermometer_Full,
    Thermometer_Half,
    Thermometer_Quarter,
    Thermometer_Three_Quarters,
    Thumbs_Down,
    Thumbs_Down_Outline,
    Thumbs_Up,
    Thumbs_Up_Outline,
    Thumbtack,
    Ticket_Alternate,
    Times,
    Times_Circle,
    Times_Circle_Outline,
    Tint,
    Toggle_Off,
    Toggle_On,
    Trademark,
    Train,
    Transgender,
    Transgender_Alternate,
    Trash,
    Trash_Alternate,
    Trash_Alternate_Outline,
    Tree,
    Trello,
    Tripadvisor,
    Trophy,
    Truck,
    Tty,
    Tumblr,
    Tumblr_Square,
    Tv,
    Twitch,
    Twitter,
    Twitter_Square,
    Typo3,
    Uber,
    Uikit,
    Umbrella,
    Underline,
    Undo,
    Undo_Alternate,
    Uniregistry,
    Universal_Access,
    University,
    Unlink,
    Unlock,
    Unlock_Alternate,
    Untappd,
    Upload,
    Usb,
    User,
    User_Circle,
    User_Circle_Outline,
    User_Md,
    User_Outline,
    User_Plus,
    User_Secret,
    User_Times,
    Users,
    Ussunnah,
    Utensil_Spoon,
    Utensils,
    Vaadin,
    Venus,
    Venus_Double,
    Venus_Mars,
    Viacoin,
    Viadeo,
    Viadeo_Square,
    Viber,
    Video,
    Vimeo,
    Vimeo_Square,
    Vimeo_V,
    Vine,
    Vk,
    Vnv,
    Volleyball_Ball,
    Volume_Down,
    Volume_Off,
    Volume_Up,
    Vuejs,
    Warehouse,
    Wechat,
    Weibo,
    Weight,
    Weixin,
    Whatsapp,
    Whatsapp_Square,
    Wheelchair,
    Whmcs,
    Wifi,
    Wikipedia_W,
    Window_Close,
    Window_Close_Outline,
    Window_Maximize,
    Window_Maximize_Outline,
    Window_Minimize,
    Window_Minimize_Outline,
    Window_Restore,
    Window_Restore_Outline,
    Windows,
    Won_Sign,
    Wordpress,
    Wordpress_Simple,
    Wpbeginner,
    Wpexplorer,
    Wpforms,
    Wrench,
    X_Icon,
    Xbox,
    Xing,
    Xing_Square,
    Y_Combinator,
    Yahoo,
    Yandex,
    Yandex_International,
    Yelp,
    Yen_Sign,
    Yoast,
    Youtube,
    Youtube_Square,
    Zoom_In,
    Zoom_Out
  }
}