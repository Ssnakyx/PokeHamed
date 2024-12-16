using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.MVVM.Model;

namespace WpfApp1.MVVM.View
{
    public partial class FightView : Window
    {
        private Monster _playerMonster;
        private Monster _opponentMonster;

        public FightView(Monster playerMonster, Monster opponentMonster)
        {
            InitializeComponent();

            // Stocker les monstres
            _playerMonster = playerMonster;
            _opponentMonster = opponentMonster;

            // Initialiser les données pour le monstre de gauche (joueur)
            PlayerMonsterName.Text = playerMonster.Name;
            PlayerMonsterHealth.Text = $"Health: {playerMonster.Health}";
            PlayerMonsterImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(playerMonster.ImageUrl));

            // Ajouter les sorts du joueur sous forme de boutons
            if (playerMonster.Spell != null)
            {
                foreach (var spell in playerMonster.Spell)
                {
                    var spellButton = new Button
                    {
                        Content = $"{spell.Name} - Damage: {spell.Damage}",
                        Margin = new Thickness(5),
                        Tag = spell // Attacher le sort au bouton via Tag
                    };

                    // Ajouter un événement pour gérer les clics
                    spellButton.Click += OnSpellButtonClick;

                    PlayerMonsterSpells.Children.Add(spellButton);
                }
            }

            // Initialiser les données pour le monstre de droite (adversaire)
            OpponentMonsterName.Text = opponentMonster.Name;
            OpponentMonsterHealth.Text = $"Health: {opponentMonster.Health}";
            OpponentMonsterImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(opponentMonster.ImageUrl));
        }

        private void OnSpellButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button spellButton && spellButton.Tag is Spell spell)
            {
                // Réduire les points de vie de l'adversaire
                _opponentMonster.Health -= spell.Damage;

                // Vérifier si l'adversaire est KO
                if (_opponentMonster.Health <= 0)
                {
                    _opponentMonster.Health = 0; // Éviter les valeurs négatives
                    MessageBox.Show($"{_playerMonster.Name} a vaincu {_opponentMonster.Name} !");
                }

                // Mettre à jour l'affichage des points de vie
                OpponentMonsterHealth.Text = $"Health: {_opponentMonster.Health}";
            }
        }
    }
}
