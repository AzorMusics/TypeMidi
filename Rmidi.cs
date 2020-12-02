using ChromaSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeMidi
{
    class Rmidi
    {

        private static int _mResult = 0;

        public static int GetInitResult()
        {
            return _mResult;
        }

        public static ChromaSDK.Keyboard.RZKEY[] chromaKeys =
        {
			ChromaSDK.Keyboard.RZKEY.RZKEY_ESC,                 /*!< Esc (VK_ESCAPE) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F1,                  /*!< F1 (VK_F1) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F2,                  /*!< F2 (VK_F2) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F3,                  /*!< F3 (VK_F3) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F4,                  /*!< F4 (VK_F4) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F5,                  /*!< F5 (VK_F5) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F6,                  /*!< F6 (VK_F6) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F7,                  /*!< F7 (VK_F7) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F8,                  /*!< F8 (VK_F8) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F9,                  /*!< F9 (VK_F9) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F10,                 /*!< F10 (VK_F10) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F11,                 /*!< F11 (VK_F11) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F12,                 /*!< F12 (VK_F12) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_1,                   /*!< 1 (VK_1) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_2,                   /*!< 2 (VK_2) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_3,                   /*!< 3 (VK_3) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_4,                   /*!< 4 (VK_4) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_5,                   /*!< 5 (VK_5) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_6,                   /*!< 6 (VK_6) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_7,                   /*!< 7 (VK_7) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_8,                   /*!< 8 (VK_8) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_9,                   /*!< 9 (VK_9) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_0,                   /*!< 0 (VK_0) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_A,                   /*!< A (VK_A) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_B,                   /*!< B (VK_B) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_C,                   /*!< C (VK_C) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_D,                   /*!< D (VK_D) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_E,                   /*!< E (VK_E) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_F,                   /*!< F (VK_F) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_G,                   /*!< G (VK_G) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_H,                   /*!< H (VK_H) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_I,                   /*!< I (VK_I) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_J,                   /*!< J (VK_J) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_K,                   /*!< K (VK_K) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_L,                   /*!< L (VK_L) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_M,                   /*!< M (VK_M) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_N,                   /*!< N (VK_N) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_O,                   /*!< O (VK_O) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_P,                   /*!< P (VK_P) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_Q,                   /*!< Q (VK_Q) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_R,                   /*!< R (VK_R) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_S,                   /*!< S (VK_S) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_T,                   /*!< T (VK_T) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_U,                   /*!< U (VK_U) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_V,                   /*!< V (VK_V) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_W,                   /*!< W (VK_W) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_X,                   /*!< X (VK_X) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_Y,                   /*!< Y (VK_Y) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_Z,                   /*!< Z (VK_Z) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMLOCK,             /*!< Numlock (VK_NUMLOCK) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD0,             /*!< Numpad 0 (VK_NUMPAD0) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD1,             /*!< Numpad 1 (VK_NUMPAD1) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD2,             /*!< Numpad 2 (VK_NUMPAD2) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD3,             /*!< Numpad 3 (VK_NUMPAD3) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD4,             /*!< Numpad 4 (VK_NUMPAD4) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD5,             /*!< Numpad 5 (VK_NUMPAD5) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD6,             /*!< Numpad 6 (VK_NUMPAD6) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD7,             /*!< Numpad 7 (VK_NUMPAD7) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD8,             /*!< Numpad 8 (VK_NUMPAD8) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD9,             /*!< Numpad 9 (VK_ NUMPAD9*/
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD_DIVIDE,       /*!< Divide (VK_DIVIDE) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD_MULTIPLY,     /*!< Multiply (VK_MULTIPLY) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD_SUBTRACT,     /*!< Subtract (VK_SUBTRACT) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD_ADD,          /*!< Add (VK_ADD) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD_ENTER,        /*!< Enter (VK_RETURN - Extended) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_NUMPAD_DECIMAL,      /*!< Decimal (VK_DECIMAL) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_PRINTSCREEN,         /*!< Print Screen (VK_PRINT) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_SCROLL,              /*!< Scroll Lock (VK_SCROLL) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_PAUSE,               /*!< Pause (VK_PAUSE) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_INSERT,              /*!< Insert (VK_INSERT) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_HOME,                /*!< Home (VK_HOME) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_PAGEUP,              /*!< Page Up (VK_PRIOR) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_DELETE,              /*!< Delete (VK_DELETE) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_END,                 /*!< End (VK_END) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_PAGEDOWN,            /*!< Page Down (VK_NEXT) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_UP,                  /*!< Up (VK_UP) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_LEFT,                /*!< Left (VK_LEFT) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_DOWN ,                /*!< Down (VK_DOWN) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_RIGHT,               /*!< Right (VK_RIGHT) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_TAB,                 /*!< Tab (VK_TAB) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_CAPSLOCK,            /*!< Caps Lock(VK_CAPITAL) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_BACKSPACE,           /*!< Backspace (VK_BACK) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_ENTER,               /*!< Enter (VK_RETURN) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_LCTRL,               /*!< Left Control(VK_LCONTROL) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_LWIN,                /*!< Left Window (VK_LWIN) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_LALT,                /*!< Left Alt (VK_LMENU) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_SPACE,               /*!< Spacebar (VK_SPACE) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_RALT,                /*!< Right Alt (VK_RMENU) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_FN,                  /*!< Function key. */
			ChromaSDK.Keyboard.RZKEY.RZKEY_RMENU,               /*!< Right Menu (VK_APPS) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_RCTRL,               /*!< Right Control (VK_RCONTROL) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_LSHIFT,              /*!< Left Shift (VK_LSHIFT) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_RSHIFT,              /*!< Right Shift (VK_RSHIFT) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_MACRO1,              /*!< Macro Key 1 */
			ChromaSDK.Keyboard.RZKEY.RZKEY_MACRO2,              /*!< Macro Key 2 */
			ChromaSDK.Keyboard.RZKEY.RZKEY_MACRO3,              /*!< Macro Key 3 */
			ChromaSDK.Keyboard.RZKEY.RZKEY_MACRO4,              /*!< Macro Key 4 */
			ChromaSDK.Keyboard.RZKEY.RZKEY_MACRO5,              /*!< Macro Key 5 */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_1 ,               /*!< ~ (tilde/半角/全角) (VK_OEM_3) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_2 ,               /*!< -- (minus) (VK_OEM_MINUS) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_3 ,               /*!< = (equal) (VK_OEM_PLUS) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_4 ,               /*!< [ (left sqaure bracket) (VK_OEM_4) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_5 ,               /*!< ] (right square bracket) (VK_OEM_6) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_6,               /*!< \ (backslash) (VK_OEM_5) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_7,               /*!< ; (semi-colon) (VK_OEM_1) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_8,               /*!< ' (apostrophe) (VK_OEM_7) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_9,               /*!< , (comma) (VK_OEM_COMMA) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_10,              /*!< . (period) (VK_OEM_PERIOD) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_OEM_11,              /*!< / (forward slash) (VK_OEM_2) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_EUR_1 ,               /*!< "#" (VK_OEM_5) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_EUR_2 ,               /*!< \ (VK_OEM_102) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_JPN_1 ,               /*!< ¥ (0xFF) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_JPN_2 ,               /*!< \ (0xC1) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_JPN_3 ,               /*!< 無変換 (VK_OEM_PA1) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_JPN_4 ,               /*!< 変換 (0xFF) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_JPN_5 ,               /*!< ひらがな/カタカナ (0xFF) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_KOR_1 ,               /*!< | (0xFF) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_KOR_2 ,               /*!< (VK_OEM_5) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_KOR_3,               /*!< (VK_OEM_102) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_KOR_4,               /*!< (0xC1) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_KOR_5,               /*!< (VK_OEM_PA1) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_KOR_6,               /*!< 한/영 (0xFF) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_KOR_7,               /*!< (0xFF) */
			ChromaSDK.Keyboard.RZKEY.RZKEY_INVALID             /*!< Invalid keys. */
        };

        public static void Init()
        {
            _mResult = ChromaAnimationAPI.Init();
            switch (_mResult)
            {
                case RazerErrors.RZRESULT_DLL_NOT_FOUND:
                    Console.Error.WriteLine("Chroma DLL is not found! {0}", RazerErrors.GetResultString(_mResult));
                    break;
                case RazerErrors.RZRESULT_DLL_INVALID_SIGNATURE:
                    Console.Error.WriteLine("Chroma DLL has an invalid signature! {0}", RazerErrors.GetResultString(_mResult));
                    break;
                case RazerErrors.RZRESULT_SUCCESS:
                    break;
                default:
                    Console.Error.WriteLine("Failed to initialize Chroma! {0}", RazerErrors.GetResultString(_mResult));
                    break;
            }

            Update();


        }

        public static int[] rVelocity = { 0, 16, 32, 63, 63, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 33, 20, 10, 5, 18, 0, 0, 0, 18, 0, 0, 0, 18, 0, 0, 0, 18, 0, 0, 0, 18, 0, 0, 0, 18, 0, 0, 0, 11, 0, 0, 0, 26, 11, 6, 3, 63, 63, 32, 16, 63, 63, 32, 16, 63, 37, 29, 8, 0, 0, 0, 0, 0, 4, 31, 7, 63, 46, 43, 24, 3, 0, 0, 0, 6, 22, 43, 10, 63, 33, 28, 0, 14, 21, 13, 22, 12, 26, 52, 63, 63, 45, 35, 32, 14, 0, 3, 5, 5, 25, 32, 54, 53, 63, 39, 25, 5, 54, 31, 38, 35, 15, 28, 55, 39, 13, 6, 1, 45, 15, 44, 18 };

        public static int[] gVelocity = { 0, 16, 32, 63, 15, 0, 0, 0, 46, 15, 8, 4, 43, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 48, 41, 21, 11, 33, 21, 11, 6, 9, 0, 0, 0, 13, 0, 0, 0, 15, 0, 0, 0, 16, 0, 0, 0, 3, 13, 20, 13, 14, 18, 5, 0, 17, 0, 31, 7, 0, 63, 58, 63, 34, 63, 41, 10, 0, 0, 6, 4, 12, 55, 63, 63, 63, 63, 63, 34, 20, 20, 7, 0, 17, 41, 63, 22, 10, 18, 19, 5, 7, 14, 0, 16, 18, 47, 55, 44, 5, 52, 58, 37, 25, 15, 28, 63, 0, 0, 51, 16, 43, 12, 20, 5 };

        public static int[] bVelocity = { 0, 16, 32, 63, 15, 0, 0, 0, 26, 0, 0, 0, 11, 0, 0, 0, 12, 0, 0, 0, 18, 0, 0, 0, 23, 6, 3, 1, 22, 21, 11, 6, 45, 37, 18, 9, 63, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 62, 63, 32, 16, 63, 63, 32, 16, 27, 20, 10, 5, 0, 0, 0, 1, 0, 6, 27, 63, 19, 50, 31, 7, 0, 11, 1, 2, 0, 23, 63, 63, 63, 63, 30, 0, 0, 1, 5, 0, 9, 27, 50, 63, 48, 57, 63, 22, 0, 0, 0, 1, 0, 3, 8, 10, 22, 6, 0, 10, 4, 9, 11, 3, 11, 26, 34, 63, 63, 15, 28, 63, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static void palette_led(int p, int v)
        {
            rgb_led(p, rVelocity[v] * 6, gVelocity[v] * 6, bVelocity[v] * 6);
        }

        public static int[] rValue = new int[128];
        public static int[] gValue = new int[128];
        public static int[] bValue = new int[128];

        public static void rgb_led(int p, int rVal, int gVal, int bVal)
        {
            rValue[p] = rVal;
            gValue[p] = gVal;
            bValue[p] = bVal;

            Update();
        }

        

        public static void Update()
        {
            string curr = "Animations/Key.chroma";

            ChromaAnimationAPI.CloseAnimationName(curr);

            for(int i = 0; i < 127; i++)
            {
                try
                {
                    ChromaAnimationAPI.SetKeyColorAllFramesRGBName(curr, (int)chromaKeys[i], rValue[i], gValue[i], bValue[i]);
                }
                catch
                {

                }
            }

            ChromaAnimationAPI.PlayAnimationName(curr, true);
        }


    }
}
