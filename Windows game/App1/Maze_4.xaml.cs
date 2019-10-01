using Microsoft.Graphics.Canvas.UI.Xaml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.UI;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Gaming.Input;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    public sealed partial class Maze_4 : Page
    {
        //Character Character;
        Random random;
        Sword weapon;
        bool MoveDown = false;
        bool MoveUp = false;
        bool MoveLeft = false;
        bool MoveRight = false;
        List<Curtis_sRect> walls = new List<Curtis_sRect>();
        List<Enemy> enemies = new List<Enemy>();
        Enemy enemy1 = new Enemy(540, 100);
        Enemy enemy2 = new Enemy(200, 100);
        Enemy enemy3 = new Enemy(750, 400);

        private Gamepad gamepad = null;

        public Maze_4()
        {
            walls.Add(new Curtis_sRect(0, 0, 960, 20, 20));
            walls.Add(new Curtis_sRect(0, 0, 20, 540, 20));
            walls.Add(new Curtis_sRect(460, 0, 20, 270, 20));
            walls.Add(new Curtis_sRect(460, 270, 500, 20, 20));
            walls.Add(new Curtis_sRect(940, 270, 20, 270, 20));
            walls.Add(new Curtis_sRect(460, 520, 20, 20, 20));
            walls.Add(new Curtis_sRect(690, 520, 300, 20, 20));
            enemies.Add(enemy1);
            enemies.Add(enemy2);
            enemies.Add(enemy3);
            this.InitializeComponent();
          //  Character = new Character();
            random = new Random();

            weapon = new Sword();
        }

        private async void CanvasAnimatedControl_Update(ICanvasAnimatedControl sender, CanvasAnimatedUpdateEventArgs args)
        {
            if (gamepad == null && Gamepad.Gamepads.Count > 0) gamepad = Gamepad.Gamepads[0];

            if (gamepad != null)
            {
                var reading = gamepad.GetCurrentReading();

                Character.MoveCharacter((float)reading.LeftThumbstickX, (float)reading.LeftThumbstickY, walls);

                switch (reading.Buttons)
                {
                    case GamepadButtons.Menu:
                        //gameManager.gameOver = true;
                        break;
                    case GamepadButtons.X:
                        //gameManager.MultiBall();
                        break;
                    case GamepadButtons.Y:
                        //gameManager.StackedPaddle();
                        break;
                    case GamepadButtons.B:
                        //gameManager.WidePaddle();
                        break;
                    case GamepadButtons.A:
                        //gameManager.Explode();
                        break;
                    default:
                        break;
                }
            }



            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {


                foreach (Enemy x in enemies)
                {
                    if (x.X_Location >= Character.X_Location - 45 && x.Y_Location >= Character.Y_Location - 45
                     && x.X_Location <= Character.X_Location + 45 && x.Y_Location <= Character.Y_Location + 45)
                    {
                        this.Frame.Navigate(typeof(Loser));
                    }
                }

                if (weapon.X_Location >= Character.X_Location - 20 && weapon.Y_Location >= Character.Y_Location - 20
                 && weapon.X_Location <= Character.X_Location + 45 && weapon.Y_Location <= Character.Y_Location + 45)
                {
                    weapon.Collect();
                }
                if (Character.X_Location > 960)
                {
                    Character.X_Location = 50;
                    Character.Y_Location = 90;
                    this.Frame.Navigate(typeof(Maze_2));
                }
                if (Character.Y_Location > 540)
                {
                    Character.Y_Location = 50;
                    this.Frame.Navigate(typeof(Maze_5));
                    //if (Character.X_Location < 270)
                    //{
                    //    //character.x_location = 910;
                    //    Character.Y_Location = 490;
                    //}
                    //if (Character.X_Location > 270)
                    //    //character.x_location = 910;
                    //    Character.Y_Location = 490;
                    //this.Frame.Navigate(typeof(Maze_2));
                }
            });
        }

        private void GameCanvas_KeyDown(CoreWindow sender, KeyEventArgs args)
        {
            args.Handled = true;
            var virtualKey = args.VirtualKey;
            var action = GameCanvas.RunOnGameLoopThreadAsync(() => KeyDown_GameLoopThread(virtualKey));
        }

        private void GameCanvas_KeyUp(CoreWindow sender, KeyEventArgs args)
        {
            args.Handled = true;
            var virtualKey = args.VirtualKey;
            var action = GameCanvas.RunOnGameLoopThreadAsync(() => KeyUp_GameLoopThread(virtualKey));
        }

        private void KeyDown_GameLoopThread(VirtualKey virtualKey)
        {
            switch (virtualKey)
            {
                case VirtualKey.Up:
                    MoveUp = true;
                    break;
                case VirtualKey.Down:
                    MoveDown = true;
                    break;
                case VirtualKey.Left:
                    MoveLeft = true;
                    break;
                case VirtualKey.Right:
                    MoveRight = true;
                    break;
                default:
                    break;
            }
            if (MoveRight)
            {
                Character.MoveCharacter(2, 0, walls);
            }
            if (MoveLeft)
            {
                Character.MoveCharacter(-2, 0, walls);
            }
            if (MoveUp)
            {
                Character.MoveCharacter(0, 2, walls);
            }
            if (MoveDown)
            {
                Character.MoveCharacter(0, -2, walls);
            }
        }

        private void KeyUp_GameLoopThread(VirtualKey virtualKey)
        {
            switch (virtualKey)
            {
                case VirtualKey.Up:
                    MoveUp = false;
                    break;
                case VirtualKey.Down:
                    MoveDown = false;
                    break;
                case VirtualKey.Left:
                    MoveLeft = false;
                    break;
                case VirtualKey.Right:
                    MoveRight = false;
                    break;

                    break;
                default:
                    break;
            }
        }

        void CanvasControl_Draw(ICanvasAnimatedControl sender, CanvasAnimatedDrawEventArgs args)
        {
            //args.DrawingSession.DrawText("Hello, world!", 100, 100, Colors.Yellow);
            if (!Character.swordCollected)
            {
               // args.DrawingSession.DrawRectangle(weapon.X_Location + 5f, weapon.Y_Location - 23f, 10, 46, Colors.Plum, 10);
                args.DrawingSession.DrawRectangle(Character.X_Location - 15f, Character.Y_Location - 12.5f, 25, 25, Colors.Black, 25);
            }
            if (Character.swordCollected)
            {
                args.DrawingSession.DrawRectangle(Character.X_Location - 15f, Character.Y_Location - 12.5f, 25, 25, Colors.Plum, 25);
            }
            foreach (Enemy x in enemies)
            {
                args.DrawingSession.DrawEllipse(x.X_Location, x.Y_Location, 10, 10, Colors.Green, 20);
                x.MoveToPlayer(Character.X_Location, Character.Y_Location);
            }
            foreach (Curtis_sRect x in walls)
            {
                args.DrawingSession.DrawRectangle(x.x, x.y, x.width, x.height, Colors.Black, x.brushSize);
            }


        }

        private void Gamepad_GamepadRemoved(object sender, Gamepad e)
        {
            gamepad = null;
        }

        private void Gamepad_GamepadAdded(object sender, Gamepad e)
        {
            gamepad = e;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Gamepad.GamepadAdded += Gamepad_GamepadAdded;
            Gamepad.GamepadRemoved += Gamepad_GamepadRemoved;
            Window.Current.CoreWindow.KeyDown += GameCanvas_KeyDown;
            Window.Current.CoreWindow.KeyUp += GameCanvas_KeyUp;
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            Gamepad.GamepadAdded -= Gamepad_GamepadAdded;
            Gamepad.GamepadRemoved -= Gamepad_GamepadRemoved;
            Window.Current.CoreWindow.KeyDown -= GameCanvas_KeyDown;
            Window.Current.CoreWindow.KeyUp -= GameCanvas_KeyUp;
            GameCanvas.RemoveFromVisualTree();
            GameCanvas = null;
        }
    }
}
