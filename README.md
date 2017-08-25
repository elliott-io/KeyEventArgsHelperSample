# KeyEventArgsHelperSample
MIT license for use of any kind.

Helper to check for modifier and system keys during input, with counter excluding said input.

KeyEventArgsHelper.cs file containts helpers.

A simple method to check for keyboard modifiers:

        public static bool ModifierKey(KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.None)
                return false;
            else
                return true;
        }

As well as a method to check for each system key (modifier keys are commented out in case someone wants to just use that method and uncomment the appropriate lines):

        public static bool SystemKey(KeyEventArgs e)
        {
            switch (e.Key)
            {
                //case Key.LeftAlt:
                //    return true;
                //case Key.RightAlt:
                //    return true;
                //case Key.LeftCtrl:
                //    return true;
                //case Key.RightCtrl:
                //    return true;
                //case Key.LeftShift:
                //    return true;
                //case Key.RightShift:
                //    return true;
                //case Key.LWin:
                //    return true;
                //case Key.RWin:
                //    return true;
                case Key.Tab:
                    return true;
                case Key.CapsLock:
                    return true;
                case Key.Up:
                    return true;
                case Key.Down:
                    return true;
                case Key.Left:
                    return true;
                case Key.Right:
                    return true;
                case Key.Home:
                    return true;
                case Key.End:
                    return true;
                case Key.PageUp:
                    return true;
                case Key.PageDown:
                    return true;
                case Key.Insert:
                    return true;
                case Key.Print:
                    return true;
                case Key.PrintScreen:
                    return true;
                case Key.Escape:
                    return true;
                case Key.Delete:
                    return true;
                case Key.Back:
                    return true;
                case Key.F1:
                    return true;
                case Key.F10:
                    return true;
                case Key.F11:
                    return true;
                case Key.F12:
                    return true;
                case Key.F13:
                    return true;
                case Key.F14:
                    return true;
                case Key.F15:
                    return true;
                case Key.F16:
                    return true;
                case Key.F17:
                    return true;
                case Key.F18:
                    return true;
                case Key.F19:
                    return true;
                case Key.F20:
                    return true;
                case Key.F2:
                    return true;
                case Key.F3:
                    return true;
                case Key.F4:
                    return true;
                case Key.F5:
                    return true;
                case Key.F6:
                    return true;
                case Key.F7:
                    return true;
                case Key.F8:
                    return true;
                case Key.F9:
                    return true;
                case Key.NumLock:
                    return true;
                case Key.System:
                    return true;
                default:
                    return false;
            }
        }
