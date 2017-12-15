namespace Cinteros.XTB.BulkDataUpdater
{
    /// <summary>
    /// Structure holding constants
    /// </summary>
    internal struct Constants
    {
        #region Internal Fields

        /// <summary>
        /// Encoded large icon for plugins
        /// </summary>
        //internal const string B64_IMAGE_LARGE = "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";
        internal const string B64_IMAGE_LARGE = "iVBORw0KGgoAAAANSUhEUgAAAEsAAABKCAYAAADzEqlPAAAABGdBTUEAALGPC/xhBQAAAAlwSFlzAAAOxAAADsQBlSsOGwAADwFJREFUeF7tm2twVdUVx9d95MEjIYEQ8oSQoICWCmJ5qIAURwodHyi+6LTlqYJigVrQflC0M44YZAZ0pi2Kjh2nn9qOVuk4LR9kULR2AB8BEeQRHglBkpB3cm/uTdd/nbMu594Ekn0fsXbun9mcfc7Z95y1f3vttffZ58TVxaKk+iS3vU2qD0rCMlASloGSsAyUhGWgJCwDJWEZKAnLQElYBkrCMlBMjztnz56hyspT1NUVpNTUVHK7PZxclJ9fQHl5eXap/tWpU5V0/vy31BUMkottCQaCcryoqIgKCgslH62ihnX69GkqL3+Rjhw5Ivsul0u20OjRo2nlylU0YcIE+0jihWp88cXntOO1HdKI6alpAgsKBAJUVFwsNpWWlcmxaBQVrDNnzgioAwcO2Ee6q5BbcfXqx2n69OlhIPuiSJN6+z3K7937Eb3x+hsM6jQfcVFKSgqlpaTKb4Ps+SgzZsxV9PDKldKYpjZBxrCqqqpo06ZNDGq/feTyys4eyq25kubMmSPGX0k9msHHnEedFdQ8vOb999+nP735JjU2NIg3ud1uxtUl90xRYNwtka66+mpa8dDDVFpaKr83kVGAR4UOH/6KDh6ssI9cWfX1dbRt21b69NN/9wzDoR7bOaL1cQ1ngvbv30+vvPIyx6kaAQUwSB6On1KE84Dn8XgkfXP0KJ04flx+aypjWC0trfZe35SdnU3Dhg2TClxRvZ1nKSBI8yM5Fg0blkM+v0+OKSyXxy2QEOix9Xq9lMLJ4/WIh0Uj46lDe3ubnetdOTk5tH79BokV8RKAaApyFxyem0tPP/00FRUWUUdHhwVKCl7qqpCXvQrAoI6Odurs7JS8iYxgoUXgWdqqV1J6ejqtWbOWrrvuupCRvalX77MVgsUJv7ma49C6db9mL84iv98vnqTCedjdFZQ+yRV208WLF6WcqaLohs29ujGMXb58Bd188832kb4rElhvAOEhsOtHU6bQsmUruGE85OdjbvYk4EE3xPkAb2E34hpARdMVo4DVItvLCUH0nnsW0u233x7WwrFIgUVuVepNc269lebNm08BhgUYmCDDUuSRAkHruM/n6y9YrT3eCBWAwZMnT6ZFixbRgAED7DPmwrUigURKz2o5AEhLS6Of/+KXNHXqVIlLsBPnLVAB9sKATDUaGxqlvKmi6oaRUlAjRoyQiShGv3hLoWAreXsfUg/284iYmZlJq3+1hp8efkhtrW2hhg0wKOSRmrkO/RKz2tvb7T1LWgkE8eeee45GjRol+/GQXlvl3EfOuQ9giA6AgMZ6+JFHuPHyqK3NGr0Zk+Vh4l08El4hlFxORrBgiBOWGouuuXHjszR27DjZj6cigQGKJHuSqV4FubksGhR2lpaW0arHHqUM9rQ2tpnHT+mCGBDgcZ2cN5URLAT3pqYmyWslqqur6amnnqKbbrpJ9hMhvRe2GN1QaSS/n0c9hqVTE/iKlGFgOD958g20ZOlSSuXHHl8HT1pRxtVFdfxkgTmZqQw9y0cNeP6yDaqvr6e1a9fRggUL7BKJkwLTuZW1z3MthgdvATB4FoRzgIXt7Nk/prsXLgzFq04GXFNzPvEBPjd3BD344CIaPHiweBimB8uXLw/rCokUGijUDTnhQRlAAAGV9wCYbQuwoTtine2OO+6UOV9t7QUZMe9/4AFZ3zKV8aoDYtbu3bvp44/30tKly2jkyJH2mcQLpgIMhHjlFMAoRHgVpGUBDOHiHzvfo4mTrpd1NhwzVdSLf+iOQ4YMsff6VzBZu5kTGuIQPAfnUEYTysELMTLGNP/ji0UF639BCkIF70LswnH1Ks0DqpzjPCos8c3x276of4JNgqTxSsEIBVtODuiaWKFAXMOUAQCj8ZDvNSxIAjpXHl6FtSrI6iwWrZDnOegJLCljpn6FhQpFY2RPcs6TMEFFTAI45/UVFLbO7hqSoS39FrMqK0/S3/7yVyodU0ZlZWN4tj9WKmgiTFcqKr6ks1VVdPz4cZo2dRrNnDnTPou6YznG3mGhalo9zSs4JMDtEeJllHBYuPzBigra8tJmOnjwoBiI6cajj62mmbNm2aX6prfeeovee+9dOnToELVz/BlTVkZLFi+mhQvvlUpLVQDFLq95raJuo4WV0G7Yyd3uwz176NmNG+X1WXFxsazJf/b557Rr165uD+W96ejRo/K+MiMjgwry8+ncuXO0detW2rlzp3RLqbiz8nb+cjhM/SRhsDCngRdsKX+R/B3tlD00W4xDaw4fPpyysqwlYBOlpqbI8I9pAEY3zPOwKvrkb5+k7du38wy9NuQxYXIANPGkSCUEFt7f/Zm7zBs7XpeZMp78sQYuQzw3Jrat9tKJieA9Tm/AiujAgQMpMyOTtr28jcrLy+nkiRNyLhIYEMUCCoo7rBruGn/8w+/pnbffpgx+hhzAlcHcBoBQUWtKaD0B6GNJX6VrU07hGhgoCgoK6F1+nCnfvJk++eQTORcWk5zeZW9NFRWsy/X1Y8e+oRc3vUC7P/iAsrOGkDfFK90EFcIHGlgxwL+m5maaMmWKeIWJSkpKehxB1Z7hw4bRh3s/kk8L3ubG0m6vwLCVrAOcieLiWYg9eDP8wvPP09dfH+b4NFT8x+fzCyydZSN1tHdwt8mgGTNmGD/Mzp//0+5L1jYogEEaygNI5alT8iZ8165/UWtrqw1JAV0CdelY39RnWGpMT/r68GH63TPP0IULFzhwZwsU8aggPMpaqGNUsr3AQXjx4iXyAtZU+KBj0qRJocW+kBQYJ9wD6/DosqsfX0379u0Tu3WtKxYZe5ZCc4Krr6uT566BAzg+MSSsYDq9SaABoMzggzR37tzuFe6jsDaFkfRKAjBZXWATa7kBxVbbu5zJVFHBUml+RF4et2YGg/JbXsRwsLXy1qw6yKPhRQ7qd955V0wflV177bU0fvx4gc1Vto+yHHZBeKnq5W6ez/OxblOJKNXnq6AlFA62yOo+gq71EMujXQSsQBdGPGvpt4MnoUuWLI3aq1S33TaXUtM43jGrMA9RYLzFcdwfo/HlvMjUu4yQh4CJUbZhrIGDBlFaWjofdsmIFxoB4VU8tQrwSNjII+CsWbfEZWUVH8hZE1J/jxWGZWgcDCRDOH7JMQVpyxQUZO6ffFNBha2dBjGsrGweAW2D5M0vg5KYxaB8/gA1M6xly5eHvEp/G40wiq5a+Sh5Pd5Ljzkq+5oI8Hh2TIkYcVHWHJMlY88SsUEAYeWtF6xuj1taGi8NoM6ANRp2Bjt5+G6h63kUGzdunFzDCUmhmcLDq7drrrmG2vAJFADANts+5OFZ+OrP2eVD9uvWUOaexTfSilnBu0ue1fDZD5ZQcEHEMAR09S60MqYLWB/X32ri/6zr2oo8b5WxTzoECPfdd794DkZirGnBNtmyGpsaZSAYynO+nhQCZyBjWBhZ1HaAgPcAFr6cmX7jjdTU0iLnrBcJLu4mPvl+c+LEidZvbcACgYX/w8F0J8NnwspIOdbUqVPoKu5q8CJuQvLgM0k+XsdzuenTpvFgskSgavlYZQwLLSKVtg2AoUiYteOjkDI2Hh+LYRIIQxFT7r/3PgnIEsMclbUqHs4H2bDjjnORGjRoMC24624pgziJ70jx4hcLi1te2kK5ubn2tcIvEo1XQebdkKXzFjUCk02sTeGTxTVr19KoUSXymIFpBNadZsyaJZ6GEVKNh8E45uFYh4Rrhic0CnsKEpfVpL/XmHkbT3DLykrFhsbGRnmg3ly+mfLy8sPKxUNRw0KCMSp4F4Dhg4wNGzZQ7ohcqquvpZ/MmyePNqgMDMdv3C43d18/NbRUU0NzNTW21ESkc91SQ3MVw7amCgoMCR47n+8Bj8KsHcs0JaNLLC/mxokUfh+tol5WhjEIrIhB6FowDJfycnBP46C7Z88eem3Hdlq//kkeBccLLAjBH/ZWHPsnnTi3m2MMe5c7BeFNjncTW4d7BYJtNDp/Jv2gbD57Ygrfy/IYeGflyZP0xG+ekL+gmD17ttgBL3Z6JOTMR6OY1uDhTfq8J6Mf7+NyAIKLYik5d/hwGbEAFUTS0tOpqfkCvfOfh6i24RhfZCDTYC91WZW3KsPw+QJsnFyHq0hd3iaOUZn0s5l/p6FZBVaX5mti9IMNeD1fWFAo8OT7KxuMExR6QyyK+YUFDLWAWbAwOmJVFB6GySPOyWhlG44/hgLcU+f206HzO6iptYp8bSkU8PFAwQA0xiBe4RHKm8oDxQAfDRqcSRPz1tCYwhkMxBsW/wABg4k+Nci98M+Od9b1zF5O9KSYYeHn6I7a0vqoA6ltMNx5k1SeLMLDKs9+SQe/3U7NvjMU7GBgnbgWxyWG6U3zkodBeVLbKT0tiyaOWEcl+TfwtfHZkP25kH0DbQjJWwfC4CAfq1dBMcOCBBhPEaRlOQ9vki7J5yx7URlrq0rxplA6B+TT1V9RxblXqcV/mrtjOl8MYOEt3BXdbZTuzqGJhY9TSeEE+SDN3+kTCC4eJNAIcl0bikLDtEVAIc+QrDlf7IoLLAju74eH8VbydvfTQIzKyZaT3tDLwLC0XF1zgj478yo1+o+Qi4HBIpe3nQZ7i2hS0WNUVDBWRlosAamHqNcoIGEGD0LeLuMBKMfjTqyKGyxIIWmXRAzCvoyUdhmriiy7sphIYtXi29oqOnBqBzX4K/hUkDK842lS8QrKzx0l34QiaCOO4QoKB9dQWNrtFCa8yflcGA/FFRaEy13yKmsIRx6VxYipt7MqK1mupFtm43X1NbTv5KsUoDa6YdQqys0plufKIP8W3qJgrN9cAgUwAgvHeQtI8Co+KWXjpbjDgpyQ4G1I1r6upPItuYzzxpioIuhfbLwg57Iyc0KQnaD0uyqJRZyw2iHxi4+pN6l3xVsJgaUCJKvC1jCv0GSKgS3vR94+LTVNYPh9HRLoeceCJNMABWR5kniTDQ5/9YX4hP1EKaGwVAJGPMryMic45zEkqapU2AKlAVs8xwaFvEKCN2k3TLT6BZZKwDg8CiMl7q6gIk1RcAJHshY49SpAwrH+Ur/CUoXgAJ7mHWZoXmE54xRSfwJy6juBpcKt4W2a78kU8aaI9F3pO4X1fVPio+L/kZKwDJSEZaAkLAMlYfVZRP8F7Mr4wD7VUKQAAAAASUVORK5CYII=";
        /// <summary>
        /// Encoded small icon for plugins
        /// </summary>
        //internal const string B64_IMAGE_SMALL = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAAAFXRFWHRDcmVhdGlvbiBUaW1lAAfgBhAGDS/KOs/LAAAAB3RJTUUH4QsWDygev2CPIQAAAAlwSFlzAAAK8AAACvABQqw0mAAAAPNQTFRF9/f/1t73pb3nhKXWe5zWzt7v3uf3IVq1AEKtCEKtKWO9OWvGQnPGCEq1GFK1a5TO5+f3a4zOxtbv9///////jKXeUoTOtcbnEEq1nLXelK3eY4zO3sbv1q3n3rXn58bv9+f3c5TWjK3epUrGtWPO1rXnrb3n7973vXvW//f/rcbn1qXnzpTevXPWzpze7/f/rVrOMWu9SnvG587vKVq9IUK1GEK1vc7vWoTOQmvGOUK1Slq9UkK9SlK95+/37+//vb3n9+/3tWvW3r3vEFK1SkK9MUK1KUK1rVLOUnvG7+/3MWO9tc7nxozexoTe79b3ztb3aX3qwgAAAAF0Uk5TAEDm2GYAAAH6SURBVHjabZNrW9pAEIU3ySY7G5LIZTEXQIUFtGBBUimBWqxijai9/P9f00lCSoKcb/uc99mZnT1DyF7TRdBttU6ai3tyTPXWEzjWdmsxsKPFB1vZwiwwRKq1b4H1t+yr3tu7KKhu8WbRp0AH17nGZ38QCXg03ftcvZRF3XSEWHjR//vBF2VAyt9IcC3zDa8rUmDTTrTp/HrBwzipUk+B6JZkAMlbfOhL+YIna5k+EEbiABBfkvuE0MFFoMuwnLWM4+eantlKqD9KOXkN360tAkwTogdvcTzndjapEQwnUl4poKn2PVbQE+AHXjqEIAcGUj4i8Io1VN7IAQVoDmxwFggIppEmtrADknnsgHN8RgKENUJnGfAznsOWHAJRtAeeY88eHQEKJapPswKQ9mDVyJCTHCAzlgIuqNhkX0+abBID6jnw4FRSQAfawWeqoK4Bo2XSBFiuVisGvRRoMPh2d/fds9e+h/GkrCFc83Y+n4f+7iv006+cO+FCVJJIGNw/+lltDB6k/11j0wPg8iY7zcI0D1WnlQHjTqLx9eckUhMhNFvJIuVic4eRu/qE4/DzUAbQuyjZ/YEQQ97dxz6AVruT6+z8QgjchG5xMVyHqY3C4rim55OSqjXOaD1j9KYJp8aH7TQoA25WLNMG50Q/ut9EUTVKNbXk/gMHNVZSvASZqAAAAABJRU5ErkJggg==";
        internal const string B64_IMAGE_SMALL = "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";

        internal const int U_HEADER_MAINWIDTH = 200;

        /// <summary>
        /// Text for solution that is not available
        /// </summary>
        internal const string U_ITEM_NA = "N/A";

        /// <summary>
        /// Default solution unique name
        /// </summary>
        internal const string U_SOLUTION_DEFAULT = "Default";

        #endregion Internal Fields

        #region Internal Structs

        /// <summary>
        /// Structure holding CRM related constants
        /// </summary>
        internal struct Crm
        {
            #region Internal Structs

            /// <summary>
            /// Structure holding CRM Attributes related constants
            /// </summary>
            internal struct Attributes
            {
                #region Internal Fields

                internal const string CULTURE = "culture";
                internal const string EVENT_HANDLER = "eventhandler";
                internal const string FRIENDLY_NAME = "friendlyname";
                internal const string IS_HIDDEN = "ishidden";
                internal const string IS_MANAGED = "ismanaged";
                internal const string IS_VISIBLE = "isvisible";
                internal const string ISOLATION_MODE = "isolationmode";
                internal const string NAME = "name";
                internal const string PLUGIN_TYPE_ID = "plugintypeid";
                internal const string PUBLIC_KEY_TOKEN = "publickeytoken";
                internal const string SOLUTION_ID = "solutionid";
                internal const string STATE_CODE = "statecode";
                internal const string STATUS_CODE = "statuscode";
                internal const string UNIQUE_NAME = "uniquename";
                internal const string PRIMARY_OBJECT_TYPE_CODE = "primaryobjecttypecode";
                internal const string VERSION = "version";

                #endregion Internal Fields
            }

            /// <summary>
            /// Structure holding CRM Entities related constantns
            /// </summary>
            internal struct Entities
            {
                #region Internal Fields

                /// <summary>
                /// Name of the 'pluginassembly' entity
                /// </summary>
                internal const string PLUGIN_ASSEMBLY = "pluginassembly";

                /// <summary>
                /// Name of the 'plugintype' entity
                /// </summary>
                internal const string PLUGIN_TYPE = "plugintype";

                /// <summary>
                /// Name of the 'sdkmessageprocessingstep' entity
                /// </summary>
                internal const string PROCESSING_STEP = "sdkmessageprocessingstep";

                /// <summary>
                /// Name of the 'sdkmessage' entity
                /// </summary>
                internal const string MESSAGE = "sdkmessage";

                /// <summary>
                /// Name of the 'sdkmessagefilter' entity
                /// </summary>
                internal const string MESSAGE_FILTER = "sdkmessagefilter";

                /// <summary>
                /// Name of the 'solution' entity
                /// </summary>
                internal const string SOLUTION = "solution";

                #endregion Internal Fields
            }

            #endregion Internal Structs
        }

        /// <summary>
        /// Structure holding UI related constants
        /// </summary>
        internal struct UI
        {
            #region Internal Fields

            /// <summary>
            /// Name of the plugin toolstrip
            /// </summary>
            internal const string MENU = "tsMenu";

            #endregion Internal Fields

            #region Internal Structs

            /// <summary>
            /// Structure holding UI Buttons related constants
            /// </summary>
            internal struct Buttons
            {
                #region Internal Fields

                /// <summary>
                /// Name of toolstrip's Back button
                /// </summary>
                internal const string BACK = "tsbBack";

                /// <summary>
                /// Name of toolstrip's Compare button
                /// </summary>
                internal const string COMPARE = "tsbCompare";

                /// <summary>
                /// Name of toolstrip's Open drop down button
                /// </summary>
                internal const string OPEN = "tsddOpen";

                internal const string OPEN_CURRENT_CONNECTION = "tsmiCurrentConnection";

                internal const string OPEN_REFERENCE_FILE = "tsmiReferenceFile";

                /// <summary>
                /// Name of toolstrip's Save button
                /// </summary>
                internal const string SAVE = "tsbSave";

                #endregion Internal Fields
            }

            /// <summary>
            /// Structure holding UI Labels related constants
            /// </summary>
            internal struct Labels
            {
                #region Internal Fields

                /// <summary>
                /// Text for solutions group
                /// </summary>
                internal const string ASSEMBLIES = "Assemblies";

                /// <summary>
                /// Text for solutions group
                /// </summary>
                internal const string SOLUTIONS = "Solutions";

                #endregion Internal Fields
            }

            #endregion Internal Structs
        }

        /// <summary>
        /// Structure holding XML related constants
        /// </summary>
        internal struct Xml
        {
            #region Internal Fields

            internal const string ASSEMBLIES = "assemblies";
            internal const string ASSEMBLY = "assembly";
            internal const string FRIENDLY_NAME = "friendly-name";
            internal const string SOLUTION = "solution";
            internal const string SOLUTIONS = "solutions";
            internal const string STEP = "step";
            internal const string STEPS = "steps";
            internal const string UNIQUE_NAME = "unique-name";
            internal const string VERSION = "version";
            internal const string PLUGIN = "plugin";
            internal const string PLUGINS = "plugins";
            internal const string ID = "id";
            internal const string IMAGE = "image";

            #endregion Internal Fields
        }

        #endregion Internal Structs
    }
}