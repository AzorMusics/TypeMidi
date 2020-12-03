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
			Keyboard.RZKEY.RZKEY_ESC,
			Keyboard.RZKEY.RZKEY_F1,
			Keyboard.RZKEY.RZKEY_F2,
			Keyboard.RZKEY.RZKEY_F3,
			Keyboard.RZKEY.RZKEY_F4,
			Keyboard.RZKEY.RZKEY_F5,
			Keyboard.RZKEY.RZKEY_F6,
			Keyboard.RZKEY.RZKEY_F7,
			Keyboard.RZKEY.RZKEY_F8,
			Keyboard.RZKEY.RZKEY_F9,
			Keyboard.RZKEY.RZKEY_F10,
			Keyboard.RZKEY.RZKEY_F11,
			Keyboard.RZKEY.RZKEY_F12,
			Keyboard.RZKEY.RZKEY_PRINTSCREEN,
			Keyboard.RZKEY.RZKEY_SCROLL,
			Keyboard.RZKEY.RZKEY_PAUSE,
			Keyboard.RZKEY.RZKEY_JPN_1,
			Keyboard.RZKEY.RZKEY_MACRO1,
			Keyboard.RZKEY.RZKEY_OEM_1,
			Keyboard.RZKEY.RZKEY_1,
			Keyboard.RZKEY.RZKEY_2,
			Keyboard.RZKEY.RZKEY_3,
			Keyboard.RZKEY.RZKEY_4,
			Keyboard.RZKEY.RZKEY_5,
			Keyboard.RZKEY.RZKEY_6,
			Keyboard.RZKEY.RZKEY_7,
			Keyboard.RZKEY.RZKEY_8,
			Keyboard.RZKEY.RZKEY_9,
			Keyboard.RZKEY.RZKEY_0,
			Keyboard.RZKEY.RZKEY_OEM_2,
			Keyboard.RZKEY.RZKEY_OEM_3,
			Keyboard.RZKEY.RZKEY_BACKSPACE,
			Keyboard.RZKEY.RZKEY_INSERT,
			Keyboard.RZKEY.RZKEY_HOME,
			Keyboard.RZKEY.RZKEY_PAGEUP,
			Keyboard.RZKEY.RZKEY_NUMLOCK,
			Keyboard.RZKEY.RZKEY_NUMPAD_DIVIDE,
			Keyboard.RZKEY.RZKEY_NUMPAD_MULTIPLY,
			Keyboard.RZKEY.RZKEY_NUMPAD_SUBTRACT,
			Keyboard.RZKEY.RZKEY_MACRO2,
			Keyboard.RZKEY.RZKEY_TAB,
			Keyboard.RZKEY.RZKEY_Q,
			Keyboard.RZKEY.RZKEY_W,
			Keyboard.RZKEY.RZKEY_E,
			Keyboard.RZKEY.RZKEY_R,
			Keyboard.RZKEY.RZKEY_T,
			Keyboard.RZKEY.RZKEY_Y,
			Keyboard.RZKEY.RZKEY_U,
			Keyboard.RZKEY.RZKEY_I,
			Keyboard.RZKEY.RZKEY_O,
			Keyboard.RZKEY.RZKEY_P,
			Keyboard.RZKEY.RZKEY_OEM_4,
			Keyboard.RZKEY.RZKEY_OEM_5,
			Keyboard.RZKEY.RZKEY_OEM_6,
			Keyboard.RZKEY.RZKEY_DELETE,
			Keyboard.RZKEY.RZKEY_END,
			Keyboard.RZKEY.RZKEY_PAGEDOWN,
			Keyboard.RZKEY.RZKEY_NUMPAD7,
			Keyboard.RZKEY.RZKEY_NUMPAD8,
			Keyboard.RZKEY.RZKEY_NUMPAD9,
			Keyboard.RZKEY.RZKEY_NUMPAD_ADD,
			Keyboard.RZKEY.RZKEY_MACRO3,
			Keyboard.RZKEY.RZKEY_CAPSLOCK,
			Keyboard.RZKEY.RZKEY_A,
			Keyboard.RZKEY.RZKEY_S,
			Keyboard.RZKEY.RZKEY_D,
			Keyboard.RZKEY.RZKEY_F,
			Keyboard.RZKEY.RZKEY_G,
			Keyboard.RZKEY.RZKEY_H,
			Keyboard.RZKEY.RZKEY_J,
			Keyboard.RZKEY.RZKEY_K,
			Keyboard.RZKEY.RZKEY_L,
			Keyboard.RZKEY.RZKEY_OEM_7,
			Keyboard.RZKEY.RZKEY_OEM_8,
			Keyboard.RZKEY.RZKEY_EUR_1,
			Keyboard.RZKEY.RZKEY_ENTER,
			Keyboard.RZKEY.RZKEY_NUMPAD0,
			Keyboard.RZKEY.RZKEY_NUMPAD1,
			Keyboard.RZKEY.RZKEY_NUMPAD2,
			Keyboard.RZKEY.RZKEY_NUMPAD3,
			Keyboard.RZKEY.RZKEY_NUMPAD4,
			Keyboard.RZKEY.RZKEY_NUMPAD5,
			Keyboard.RZKEY.RZKEY_NUMPAD6,
			Keyboard.RZKEY.RZKEY_NUMPAD7,
			Keyboard.RZKEY.RZKEY_NUMPAD8,
			Keyboard.RZKEY.RZKEY_NUMPAD9,
			Keyboard.RZKEY.RZKEY_NUMPAD_DIVIDE,
			Keyboard.RZKEY.RZKEY_NUMPAD_MULTIPLY,
			Keyboard.RZKEY.RZKEY_NUMPAD_SUBTRACT,
			Keyboard.RZKEY.RZKEY_NUMPAD_ADD,
			Keyboard.RZKEY.RZKEY_NUMPAD_ENTER,
			Keyboard.RZKEY.RZKEY_NUMPAD_DECIMAL,
			Keyboard.RZKEY.RZKEY_PRINTSCREEN,
			Keyboard.RZKEY.RZKEY_SCROLL,
			Keyboard.RZKEY.RZKEY_PAUSE,
			Keyboard.RZKEY.RZKEY_INSERT,
			Keyboard.RZKEY.RZKEY_HOME,
			Keyboard.RZKEY.RZKEY_PAGEUP,
			Keyboard.RZKEY.RZKEY_DELETE,
			Keyboard.RZKEY.RZKEY_END,
			Keyboard.RZKEY.RZKEY_PAGEDOWN,
			Keyboard.RZKEY.RZKEY_UP,
			Keyboard.RZKEY.RZKEY_LEFT,
			Keyboard.RZKEY.RZKEY_DOWN,
			Keyboard.RZKEY.RZKEY_RIGHT,
			Keyboard.RZKEY.RZKEY_TAB,
			Keyboard.RZKEY.RZKEY_CAPSLOCK,
			Keyboard.RZKEY.RZKEY_BACKSPACE,
			Keyboard.RZKEY.RZKEY_ENTER,
			Keyboard.RZKEY.RZKEY_LCTRL,
			Keyboard.RZKEY.RZKEY_LWIN,
			Keyboard.RZKEY.RZKEY_LALT,
			Keyboard.RZKEY.RZKEY_SPACE,
			Keyboard.RZKEY.RZKEY_RALT,
			Keyboard.RZKEY.RZKEY_FN,
			Keyboard.RZKEY.RZKEY_RMENU,
			Keyboard.RZKEY.RZKEY_RCTRL,
			Keyboard.RZKEY.RZKEY_LSHIFT,
			Keyboard.RZKEY.RZKEY_Z,
			Keyboard.RZKEY.RZKEY_X,
			Keyboard.RZKEY.RZKEY_C,
			Keyboard.RZKEY.RZKEY_V,
			Keyboard.RZKEY.RZKEY_B,
			Keyboard.RZKEY.RZKEY_N,
			Keyboard.RZKEY.RZKEY_M,
			Keyboard.RZKEY.RZKEY_RSHIFT,
			Keyboard.RZKEY.RZKEY_MACRO1,
			Keyboard.RZKEY.RZKEY_MACRO2,
			Keyboard.RZKEY.RZKEY_MACRO3,
			Keyboard.RZKEY.RZKEY_MACRO4,
			Keyboard.RZKEY.RZKEY_MACRO5,
			Keyboard.RZKEY.RZKEY_OEM_1,
			Keyboard.RZKEY.RZKEY_OEM_2,
			Keyboard.RZKEY.RZKEY_OEM_3,
			Keyboard.RZKEY.RZKEY_OEM_4,
			Keyboard.RZKEY.RZKEY_OEM_5,
			Keyboard.RZKEY.RZKEY_OEM_6,
			Keyboard.RZKEY.RZKEY_OEM_7,
			Keyboard.RZKEY.RZKEY_OEM_8,
			Keyboard.RZKEY.RZKEY_OEM_9,
			Keyboard.RZKEY.RZKEY_OEM_10,
			Keyboard.RZKEY.RZKEY_OEM_11,
			Keyboard.RZKEY.RZKEY_EUR_1,
			Keyboard.RZKEY.RZKEY_EUR_2,
			Keyboard.RZKEY.RZKEY_JPN_1,
			Keyboard.RZKEY.RZKEY_JPN_2,
			Keyboard.RZKEY.RZKEY_JPN_3,
			Keyboard.RZKEY.RZKEY_JPN_4,
			Keyboard.RZKEY.RZKEY_JPN_5,
			Keyboard.RZKEY.RZKEY_JPN_1,
			Keyboard.RZKEY.RZKEY_EUR_1,
			Keyboard.RZKEY.RZKEY_EUR_2,
			Keyboard.RZKEY.RZKEY_JPN_2,
			Keyboard.RZKEY.RZKEY_JPN_3,
			Keyboard.RZKEY.RZKEY_JPN_4,
			Keyboard.RZKEY.RZKEY_JPN_5,
			Keyboard.RZKEY.RZKEY_INVALID
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
