using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

     
private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == String.Empty || date.Text == String.Empty || newrank.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more required fields are empty (required fields are: Name, Date and New Rank)!");
                return;
            }
            else
            {
                string text = (@"[B]" + date.Text + @"[/B], [COLOR=#2B60DE][B]" + name.Text + @"[/B][/COLOR] has been [COLOR=""#00FF00""][B]promoted[/B][/COLOR] to [B]" + newrank.Text + @"[/B].");
                Clipboard.SetText(text);
                MessageBox.Show("Promotion roaster update code has been copied to the clipboard!");
            }
        }

        private void termination_Click(object sender, EventArgs e)
        {
            if (name.Text == String.Empty || date.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more required fields are empty (required fields are: Name and Date)!");
                return;
            }
            else
            {
                string text = @"[B]" + date.Text + "[/B], [COLOR=#2B60DE][B]" + name.Text + "[/B][/COLOR] has been [B]terminated[/B] from the department.";
                Clipboard.SetText(text);
                MessageBox.Show("Termination roaster update code has been copied to the clipboard!");
            }
        }

        private void demotion_Click(object sender, EventArgs e)
        {
            if (name.Text == String.Empty || date.Text == String.Empty || newrank.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more required fields are empty (required fields are: Name, Date and New Rank)!");
                return;
            }
            else
            {
                string text = (@"[B]" + date.Text + @"[/B], [COLOR=#2B60DE][B]" + name.Text + @"[/B][/COLOR] has been [B]demoted[/B][/COLOR] to [B]" + newrank.Text + @"[/B].");
                Clipboard.SetText(text);
                MessageBox.Show("Demotion roaster update code has been copied to the clipboard!");
            }
        }

        private void stepdown_Click(object sender, EventArgs e)
        {
            if (name.Text == String.Empty || newrank.Text == String.Empty || date.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more required fields are empty (required fields are: Name, Date and New Rank)!");
                return;
            }
            else
            {
                string text = @"[B]" + date.Text + "[/B], [COLOR=#2B60DE][B]" + name.Text + "[/B][/COLOR] has [B]stepped down[/B] to [B]" + newrank.Text + "[/B]";
                Clipboard.SetText(text);
                MessageBox.Show("Stepdown roaster update code has been copied to the clipboard!");
            }
        }

        private void resigned_Click(object sender, EventArgs e)
        {
            if (name.Text == String.Empty || date.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more required fields are empty (required fields are: Name and Date)!");
                return;
            }
            else
            {
                string text = @"[B]" + date.Text + "[/B], [B]" + name.Text + "[/B] has [B]resigned[/B] from the department.";
                Clipboard.SetText(text);
                MessageBox.Show("Resignation roaster update code has been copied to the clipboard!");
            }
        }

        private void supervisor_Click(object sender, EventArgs e)
        {
            if (name.Text == String.Empty || div.Text == String.Empty || date.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more required fields are empty (required fields are: Name, Date and Full Division Name)!");
                return;
            }
            else
            {
                string text = @"[B]" + date.Text + "[/B], [COLOR=#2B60DE][B]" + name.Text + "[/B][/COLOR] has been appointed as the [B]" + div.Text + " Supervisor[/B]";
                Clipboard.SetText(text);
                MessageBox.Show("Division Supervisor Appointment roaster update code has been copied to the clipboard!");
            }
        }

        private void asstcmder_Click(object sender, EventArgs e)
        {
            if(date.Text == String.Empty || name.Text == String.Empty || div.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more required fields are empty (required fields are: Name, Date and Full Division Name)!");
                return;
            }
            else
            {
                string text = @"[B]" + date.Text + "[/B], [COLOR=#2B60DE][B]" + name.Text + "[/B][/COLOR] has been appointed as the[B] Assistant Commander [/B]of [B]" + div.Text + "[/B]";
                Clipboard.SetText(text);
                MessageBox.Show("Division Asst.Commander Appointment roaster update code has been copied to the clipboard!");
            }
        }

        private void cmder_Click(object sender, EventArgs e)
        {
            if (date.Text == String.Empty || name.Text == String.Empty || div.Text == String.Empty)
            {
                MessageBox.Show("Error: One or more required fields are empty (required fields are: Name, Date and Full Division Name)!");
                return;
            }
            else
            {
                string text = @"[B]" + date.Text + "[/B], [COLOR=#2B60DE][B]" + name.Text + "[/B][/COLOR] has been appointed as the[B] Commander [/B]of [B]" + div.Text + "[/B]";
                Clipboard.SetText(text);
                MessageBox.Show("Division Commander Appointment roaster update code has been copied to the clipboard!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (name.Text == String.Empty || div.Text == String.Empty || cntry.Text == String.Empty )
            {
                MessageBox.Show("Error: One or more required fields are empty (required fields are: Name, Country's Full Name and Full Division Name)!");
                return;
            }
            else
            {

                string[] Names = new string[] {
                "Afghanistan",
    "Albania",
    "Algeria",
    "American Samoa",
    "Andorra",
    "Angola",
    "Anguilla",
    "Antarctica",
    "Antigua and Barbuda",
    "Argentina",
    "Armenia",
    "Aruba",
    "Australia",
    "Austria",
    "Azerbaijan",
    "Bahamas",
    "Bahrain",
    "Bangladesh",
    "Barbados",
    "Belarus",
    "Belgium",
    "Belize",
    "Benin",
    "Bermuda",
    "Bhutan",
    "Bolivia",
    "Bosnia and Herzegovina",
    "Botswana",
    "Bouvet Island",
    "Brazil",
    "British Indian Ocean Territory",
    "Brunei Darussalam",
    "Bulgaria",
    "Burkina Faso",
    "Burundi",
    "Cambodia",
    "Cameroon",
    "Canada",
    "Cape Verde",
    "Cayman Islands",
    "Central African Republic",
    "Chad",
    "Chile",
    "China",
    "Christmas Island",
    "Cocos (Keeling) Islands",
    "Colombia",
    "Comoros",
    "Congo",
    "Congo, the Democratic Republic of the",
    "Cook Islands",
    "Costa Rica",
    "Cote D'Ivoire",
    "Croatia",
    "Cuba",
    "Cyprus",
    "Czech Republic",
    "Denmark",
    "Djibouti",
    "Dominica",
    "Dominican Republic",
    "Ecuador",
    "Egypt",
    "El Salvador",
    "Equatorial Guinea",
    "Eritrea",
    "Estonia",
    "Ethiopia",
    "Falkland Islands (Malvinas)",
    "Faroe Islands",
    "Fiji",
    "Finland",
    "France",
    "French Guiana",
    "French Polynesia",
    "French Southern Territories",
    "Gabon",
    "Gambia",
    "Georgia",
    "Germany",
    "Ghana",
    "Gibraltar",
    "Greece",
    "Greenland",
    "Grenada",
    "Guadeloupe",
    "Guam",
    "Guatemala",
    "Guinea",
    "Guinea-Bissau",
    "Guyana",
    "Haiti",
    "Heard Island and Mcdonald Islands",
    "Holy See (Vatican City State)",
    "Honduras",
    "Hong Kong",
    "Hungary",
    "Iceland",
    "India",
    "Indonesia",
    "Iran, Islamic Republic of",
    "Iraq",
    "Ireland",
    "Israel",
    "Italy",
    "Jamaica",
    "Japan",
    "Jordan",
    "Kazakhstan",
    "Kenya",
    "Kiribati",
    "Korea, Democratic People's Republic of",
    "Korea, Republic of",
    "Kuwait",
    "Kyrgyzstan",
    "Lao People's Democratic Republic",
    "Latvia",
    "Lebanon",
    "Lesotho",
    "Liberia",
    "Libyan Arab Jamahiriya",
    "Liechtenstein",
    "Lithuania",
    "Luxembourg",
    "Macao",
    "Macedonia, the Former Yugoslav Republic of",
    "Madagascar",
    "Malawi",
    "Malaysia",
    "Maldives",
    "Mali",
    "Malta",
    "Marshall Islands",
    "Martinique",
    "Mauritania",
    "Mauritius",
    "Mayotte",
    "Mexico",
    "Micronesia, Federated States of",
    "Moldova, Republic of",
    "Monaco",
    "Mongolia",
    "Montserrat",
    "Morocco",
    "Mozambique",
    "Myanmar",
    "Namibia",
    "Nauru",
    "Nepal",
    "Netherlands",
    "Netherlands Antilles",
    "New Caledonia",
    "New Zealand",
    "Nicaragua",
    "Niger",
    "Nigeria",
    "Niue",
    "Norfolk Island",
    "Northern Mariana Islands",
    "Norway",
    "Oman",
    "Pakistan",
    "Palau",
    "Palestinian Territory, Occupied",
    "Panama",
    "Papua New Guinea",
    "Paraguay",
    "Peru",
    "Philippines",
    "Pitcairn",
    "Poland",
    "Portugal",
    "Puerto Rico",
    "Qatar",
    "Reunion",
    "Romania",
    "Russian Federation",
    "Rwanda",
    "Saint Helena",
    "Saint Kitts and Nevis",
    "Saint Lucia",
    "Saint Pierre and Miquelon",
    "Saint Vincent and the Grenadines",
    "Samoa",
    "San Marino",
    "Sao Tome and Principe",
    "Saudi Arabia",
    "Senegal",
    "Serbia and Montenegro",
    "Seychelles",
    "Sierra Leone",
    "Singapore",
    "Slovakia",
    "Slovenia",
    "Solomon Islands",
    "Somalia",
    "South Africa",
    "South Georgia and the South Sandwich Islands",
    "Spain",
    "Sri Lanka",
    "Sudan",
    "Suriname",
    "Svalbard and Jan Mayen",
    "Swaziland",
    "Sweden",
    "Switzerland",
    "Syrian Arab Republic",
    "Taiwan, Province of China",
    "Tajikistan",
    "Tanzania, United Republic of",
    "Thailand",
    "Timor-Leste",
    "Togo",
    "Tokelau",
    "Tonga",
    "Trinidad and Tobago",
    "Tunisia",
    "Turkey",
    "Turkmenistan",
    "Turks and Caicos Islands",
    "Tuvalu",
    "Uganda",
    "Ukraine",
    "United Arab Emirates",
    "United Kingdom",
    "United States",
    "United States Minor Outlying Islands",
    "Uruguay",
    "Uzbekistan",
    "Vanuatu",
    "Venezuela",
    "Viet Nam",
    "Virgin Islands, British",
    "Virgin Islands, US",
    "Wallis and Futuna",
    "Western Sahara",
    "Yemen",
    "Zambia",
    "Zimbabwe",
    };
                string[] Codes = new string[]
        {
    "AF",
    "AL",
    "DZ",
    "AS",
    "AD",
    "AO",
    "AI",
    "AQ",
    "AG",
    "AR",
    "AM",
    "AW",
    "AU",
    "AT",
    "AZ",
    "BS",
    "BH",
    "BD",
    "BB",
    "BY",
    "BE",
    "BZ",
    "BJ",
    "BM",
    "BT",
    "BO",
    "BA",
    "BW",
    "BV",
    "BR",
    "IO",
    "BN",
    "BG",
    "BF",
    "BI",
    "KH",
    "CM",
    "CA",
    "CV",
    "KY",
    "CF",
    "TD",
    "CL",
    "CN",
    "CX",
    "CC",
    "CO",
    "KM",
    "CG",
    "CD",
    "CK",
    "CR",
    "CI",
    "HR",
    "CU",
    "CY",
    "CZ",
    "DK",
    "DJ",
    "DM",
    "DO",
    "EC",
    "EG",
    "SV",
    "GQ",
    "ER",
    "EE",
    "ET",
    "FK",
    "FO",
    "FJ",
    "FI",
    "FR",
    "GF",
    "PF",
    "TF",
    "GA",
    "GM",
    "GE",
    "DE",
    "GH",
    "GI",
    "GR",
    "GL",
    "GD",
    "GP",
    "GU",
    "GT",
    "GN",
    "GW",
    "GY",
    "HT",
    "HM",
    "VA",
    "HN",
    "HK",
    "HU",
    "IS",
    "IN",
    "ID",
    "IR",
    "IQ",
    "IE",
    "IL",
    "IT",
    "JM",
    "JP",
    "JO",
    "KZ",
    "KE",
    "KI",
    "KP",
    "KR",
    "KW",
    "KG",
    "LA",
    "LV",
    "LB",
    "LS",
    "LR",
    "LY",
    "LI",
    "LT",
    "LU",
    "MO",
    "MK",
    "MG",
    "MW",
    "MY",
    "MV",
    "ML",
    "MT",
    "MH",
    "MQ",
    "MR",
    "MU",
    "YT",
    "MX",
    "FM",
    "MD",
    "MC",
    "MN",
    "MS",
    "MA",
    "MZ",
    "MM",
    "NA",
    "NR",
    "NP",
    "NL",
    "AN",
    "NC",
    "NZ",
    "NI",
    "NE",
    "NG",
    "NU",
    "NF",
    "MP",
    "NO",
    "OM",
    "PK",
    "PW",
    "PS",
    "PA",
    "PG",
    "PY",
    "PE",
    "PH",
    "PN",
    "PL",
    "PT",
    "PR",
    "QA",
    "RE",
    "RO",
    "RU",
    "RW",
    "SH",
    "KN",
    "LC",
    "PM",
    "VC",
    "WS",
    "SM",
    "ST",
    "SA",
    "SN",
    "CS",
    "SC",
    "SL",
    "SG",
    "SK",
    "SI",
    "SB",
    "SO",
    "ZA",
    "GS",
    "ES",
    "LK",
    "SD",
    "SR",
    "SJ",
    "SZ",
    "SE",
    "CH",
    "SY",
    "TW",
    "TJ",
    "TZ",
    "TH",
    "TL",
    "TG",
    "TK",
    "TO",
    "TT",
    "TN",
    "TR",
    "TM",
    "TC",
    "TV",
    "UG",
    "UA",
    "AE",
    "GB",
    "US",
    "UM",
    "UY",
    "UZ",
    "VU",
    "VE",
    "VN",
    "VG",
    "VI",
    "WF",
    "EH",
    "YE",
    "ZM",
    "ZW"
        }; string country = cntry.Text.ToLower();
                string cc = null;

                for (int i = 0; i < Names.Length; i++)
                {

                    Names[i] = Names[i].ToLower();

                    if (Names[i] == country)
                    {
                        cc = Codes[i];
                    }
                    else if (i == 239 && Names[i] != country)
                    {
                        MessageBox.Show("Country not found");
                        cc = "xx";
                    }
                }
                string codes = cc.ToLower();
                string text = "[IMG]https://forums.hzgaming.net/images/flags/" + codes + ".png[/IMG] [B][COLOR=#2B60DE]" + name.Text + "[/COLOR][/B] - [FONT=century gothic][COLOR=#FFFFFF]" + div.Text + "[/COLOR][/FONT]";
                Clipboard.SetText(text);
                MessageBox.Show("Corporal Code has been copied to your clipboard!");
            }
        }
    }
    }
