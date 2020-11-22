using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeMidi
{
    class Gmidi
    {

        public static keyboardNames[] buttons =
        {
            keyboardNames.ESC,
            keyboardNames.F1,
            keyboardNames.F2,
            keyboardNames.F3,
            keyboardNames.F4,
            keyboardNames.F5,
            keyboardNames.F6,
            keyboardNames.F7,
            keyboardNames.F8,
            keyboardNames.F9,
            keyboardNames.F10,
            keyboardNames.F11,
            keyboardNames.F12,
            keyboardNames.PRINT_SCREEN,
            keyboardNames.SCROLL_LOCK,
            keyboardNames.PAUSE_BREAK,
            keyboardNames.TILDE,
            keyboardNames.ONE,
            keyboardNames.TWO,
            keyboardNames.THREE,
            keyboardNames.FOUR,
            keyboardNames.FIVE,
            keyboardNames.SIX,
            keyboardNames.SEVEN,
            keyboardNames.EIGHT,
            keyboardNames.NINE,
            keyboardNames.ZERO,
            keyboardNames.MINUS,
            keyboardNames.EQUALS,
            keyboardNames.BACKSPACE,
            keyboardNames.INSERT,
            keyboardNames.HOME,
            keyboardNames.PAGE_UP,
            keyboardNames.NUM_LOCK,
            keyboardNames.NUM_SLASH,
            keyboardNames.NUM_ASTERISK,
            keyboardNames.NUM_MINUS,
            keyboardNames.TAB,
            keyboardNames.Q,
            keyboardNames.W,
            keyboardNames.E,
            keyboardNames.R,
            keyboardNames.T,
            keyboardNames.Y,
            keyboardNames.U,
            keyboardNames.I,
            keyboardNames.O,
            keyboardNames.P,
            keyboardNames.OPEN_BRACKET,
            keyboardNames.CLOSE_BRACKET,
            keyboardNames.BACKSLASH,
            keyboardNames.KEYBOARD_DELETE,
            keyboardNames.END,
            keyboardNames.PAGE_DOWN,
            keyboardNames.NUM_SEVEN,
            keyboardNames.NUM_EIGHT,
            keyboardNames.NUM_NINE,
            keyboardNames.NUM_PLUS,
            keyboardNames.CAPS_LOCK,
            keyboardNames.A,
            keyboardNames.S,
            keyboardNames.D,
            keyboardNames.F,
            keyboardNames.G,
            keyboardNames.H,
            keyboardNames.J,
            keyboardNames.K,
            keyboardNames.L,
            keyboardNames.SEMICOLON,
            keyboardNames.APOSTROPHE,
            keyboardNames.ENTER,
            keyboardNames.NUM_FOUR,
            keyboardNames.NUM_FIVE,
            keyboardNames.NUM_SIX,
            keyboardNames.LEFT_SHIFT,
            keyboardNames.Z,
            keyboardNames.X,
            keyboardNames.C,
            keyboardNames.V,
            keyboardNames.B,
            keyboardNames.N,
            keyboardNames.M,
            keyboardNames.COMMA,
            keyboardNames.PERIOD,
            keyboardNames.FORWARD_SLASH,
            keyboardNames.RIGHT_SHIFT,
            keyboardNames.ARROW_UP,
            keyboardNames.NUM_ONE,
            keyboardNames.NUM_TWO,
            keyboardNames.NUM_THREE,
            keyboardNames.NUM_ENTER,
            keyboardNames.LEFT_CONTROL,
            keyboardNames.LEFT_WINDOWS,
            keyboardNames.LEFT_ALT,
            keyboardNames.SPACE,
            keyboardNames.RIGHT_ALT,
            keyboardNames.RIGHT_WINDOWS,
            keyboardNames.APPLICATION_SELECT,
            keyboardNames.RIGHT_CONTROL,
            keyboardNames.ARROW_LEFT,
            keyboardNames.ARROW_DOWN,
            keyboardNames.ARROW_RIGHT,
            keyboardNames.NUM_ZERO,
            keyboardNames.NUM_PERIOD,
            keyboardNames.G_1,
            keyboardNames.G_2,
            keyboardNames.G_3,
            keyboardNames.G_4,
            keyboardNames.G_5,
            keyboardNames.G_6,
            keyboardNames.G_7,
            keyboardNames.G_8,
            keyboardNames.G_9,
            keyboardNames.G_LOGO,
            keyboardNames.G_BADGE
        };


        public static int[] rVelocity = { 0, 16, 32, 63, 63, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 33, 20, 10, 5, 18, 0, 0, 0, 18, 0, 0, 0, 18, 0, 0, 0, 18, 0, 0, 0, 18, 0, 0, 0, 18, 0, 0, 0, 11, 0, 0, 0, 26, 11, 6, 3, 63, 63, 32, 16, 63, 63, 32, 16, 63, 37, 29, 8, 0, 0, 0, 0, 0, 4, 31, 7, 63, 46, 43, 24, 3, 0, 0, 0, 6, 22, 43, 10, 63, 33, 28, 0, 14, 21, 13, 22, 12, 26, 52, 63, 63, 45, 35, 32, 14, 0, 3, 5, 5, 25, 32, 54, 53, 63, 39, 25, 5, 54, 31, 38, 35, 15, 28, 55, 39, 13, 6, 1, 45, 15, 44, 18 };

        public static int[] gVelocity = { 0, 16, 32, 63, 15, 0, 0, 0, 46, 15, 8, 4, 43, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 48, 41, 21, 11, 33, 21, 11, 6, 9, 0, 0, 0, 13, 0, 0, 0, 15, 0, 0, 0, 16, 0, 0, 0, 3, 13, 20, 13, 14, 18, 5, 0, 17, 0, 31, 7, 0, 63, 58, 63, 34, 63, 41, 10, 0, 0, 6, 4, 12, 55, 63, 63, 63, 63, 63, 34, 20, 20, 7, 0, 17, 41, 63, 22, 10, 18, 19, 5, 7, 14, 0, 16, 18, 47, 55, 44, 5, 52, 58, 37, 25, 15, 28, 63, 0, 0, 51, 16, 43, 12, 20, 5 };

        public static int[] bVelocity = { 0, 16, 32, 63, 15, 0, 0, 0, 26, 0, 0, 0, 11, 0, 0, 0, 12, 0, 0, 0, 18, 0, 0, 0, 23, 6, 3, 1, 22, 21, 11, 6, 45, 37, 18, 9, 63, 63, 32, 16, 63, 63, 32, 16, 63, 63, 32, 16, 62, 63, 32, 16, 63, 63, 32, 16, 27, 20, 10, 5, 0, 0, 0, 1, 0, 6, 27, 63, 19, 50, 31, 7, 0, 11, 1, 2, 0, 23, 63, 63, 63, 63, 30, 0, 0, 1, 5, 0, 9, 27, 50, 63, 48, 57, 63, 22, 0, 0, 0, 1, 0, 3, 8, 10, 22, 6, 0, 10, 4, 9, 11, 3, 11, 26, 34, 63, 63, 15, 28, 63, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static void Init()
        {
            // Initialize the LED SDK
            bool LedInitialized = LogitechGSDK.LogiLedInitWithName("SetTargetZone Sample C#");

            if (!LedInitialized)
            {
                Console.WriteLine("LogitechGSDK.LogiLedInit() failed.");
                return;
            }

            LogitechGSDK.LogiLedSetTargetDevice(LogitechGSDK.LOGI_DEVICETYPE_ALL);

            LogitechGSDK.LogiLedSetLighting(0, 0, 0);
        }

        public static void palette_led(int p, int v)
        {
            

            rgb_led(p, rVelocity[v] * 6, gVelocity[v] * 6, bVelocity[v] * 6);
        }

        public static void rgb_led(int p, int rVal, int gVal, int bVal)
        {
            try
            {
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(buttons[p], rVal, gVal, bVal);
            }
            catch { }
        }


    }
}
