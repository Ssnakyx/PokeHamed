using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.MVVM.Model;

namespace WpfApp1.MVVM.View
{
    public partial class FightView : Window
    {
        private Monster playerMonster;
        private Monster opponentMonster;
        private static int score = 0; 

        public FightView(Monster playerMonster, Monster opponentMonster)
        {
            InitializeComponent();

            this.playerMonster = playerMonster;
            this.opponentMonster = opponentMonster;

           
            PlayerMonsterName.Text = playerMonster.Name;
            PlayerMonsterHealth.Text = $"Health: {playerMonster.Health}";
            PlayerMonsterImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(playerMonster.ImageUrl));

            foreach (var spell in playerMonster.Spell)
            {
                var button = new Button
                {
                    Content = $"{spell.Name} - Damage: {spell.Damage}",
                    Tag = spell,
                    Margin = new Thickness(5),
                    Padding = new Thickness(10),
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                button.Click += OnSpellButtonClick;
                PlayerMonsterSpells.Children.Add(button);
            }

       
            OpponentMonsterName.Text = opponentMonster.Name;
            OpponentMonsterHealth.Text = $"Health: {opponentMonster.Health}";
            OpponentMonsterImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(opponentMonster.ImageUrl));

        
            ScoreLabel.Content = $"Score: {score}";
        }

        private void OnSpellButtonClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null && button.Tag is Spell spell)
            {
            
                opponentMonster.Health -= spell.Damage;
                OpponentMonsterHealth.Text = $"Health: {Math.Max(0, opponentMonster.Health)}";

                MessageBox.Show($"You used {spell.Name} and dealt {spell.Damage} damage!");

                if (opponentMonster.Health <= 0)
                {
                  
                    score++;  

                 
                    ScoreLabel.Content = $"Score: {score}";

                    OpponentMonsterHealth.Text = "Health: 0";
                    MessageBox.Show($"{opponentMonster.Name} fainted! You win!");

                  
                    Close();
                }
                else
                {
                  
                    OpponentAttack();
                }
            }
        }

        private void OpponentAttack()
        {
            var random = new Random();
            var spell = opponentMonster.Spell.Count > 0
                ? opponentMonster.Spell.ElementAt(random.Next(opponentMonster.Spell.Count))
                : null;

            if (spell != null)
            {
                playerMonster.Health -= spell.Damage;
                PlayerMonsterHealth.Text = $"Health: {Math.Max(0, playerMonster.Health)}";

                MessageBox.Show($"{opponentMonster.Name} used {spell.Name} and dealt {spell.Damage} damage!");

                if (playerMonster.Health <= 0)
                {
                    PlayerMonsterHealth.Text = "Health: 0";
                    MessageBox.Show("Your Pokémon fainted! Game over.");
                    Close();
                }
            }
            else
            {
                MessageBox.Show($"{opponentMonster.Name} has no spells to attack.");
            }
        }
    }
}
