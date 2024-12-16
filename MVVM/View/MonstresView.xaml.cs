using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp1.MVVM.Model;
using WpfApp1.MVVM.ViewModel;

namespace WpfApp1.MVVM.View
{
    public partial class MonstresView : UserControl
    {
        public MonstresView()
        {
            InitializeComponent();
            LoadMonsterImages();
        }

        private void LoadMonsterImages()
        {
            var monsters = DataMonster.DisplayMonsterImages();
            var spells = DataSpell.DisplaySpell();

            if (monsters != null && monsters.Any())
            {
                foreach (var tupleMonster in monsters)
                {
                 
                    var monsterSpells = spells
                        .Where(s => tupleMonster.Spells.Contains(s.Id))
                        .Select(s => new Spell
                        {
                            Id = s.Id,
                            Name = s.Name,
                            Damage = s.Damage,
                            Description = s.Description
                        })
                        .ToList();

                    var monster = new Monster
                    {
                        Id = tupleMonster.Id,
                        Name = tupleMonster.Name,
                        Health = tupleMonster.Health,
                        ImageUrl = tupleMonster.ImageUrl,
                        Spell = monsterSpells
                    };

                   
                    var button = new Button
                    {
                        Margin = new Thickness(5),
                        Tag = monster
                    };
                    button.Click += (sender, args) =>
                    {
                        if (sender is Button clickedButton && clickedButton.Tag is Monster selectedMonster)
                        {
                          
                            foreach (var child in RightPanelSpells.Children)
                            {
                                if (child is StackPanel panel)
                                {
                                    panel.Visibility = Visibility.Collapsed;
                                }
                            }

                        
                            var matchingPanel = RightPanelSpells.Children
                                .OfType<StackPanel>()
                                .FirstOrDefault(panel => panel.Tag is Monster m && m.Id == selectedMonster.Id);

                            if (matchingPanel != null)
                            {
                                matchingPanel.Visibility = Visibility.Visible;
                            }
                        }
                    };

                  
                    var stackPanelLeft = new StackPanel
                    {
                        Orientation = Orientation.Vertical
                    };

                    var nameTextBlock = new TextBlock
                    {
                        Text = monster.Name,
                        FontSize = 12,
                        Margin = new Thickness(5),
                        HorizontalAlignment = HorizontalAlignment.Center
                    };
                    stackPanelLeft.Children.Add(nameTextBlock);

                    button.Content = stackPanelLeft;
                    ImageStackPanel.Children.Add(button);

                   
                    var stackPanelRight = new StackPanel
                    {
                        Orientation = Orientation.Vertical,
                        Tag = monster,
                        Visibility = Visibility.Collapsed
                    };

                    var nameHeader = new TextBlock
                    {
                        Text = $"{monster.Name}",
                        FontSize = 16,
                        Margin = new Thickness(5),
                        Foreground = Brushes.DarkSlateBlue
                    };
                    stackPanelRight.Children.Add(nameHeader);

                    var hpText = new TextBlock
                    {
                        Text = $"Health : {monster.Health}",
                        FontSize = 14,
                        Margin = new Thickness(5),
                        Foreground = Brushes.DarkSlateBlue
                    };
                    stackPanelRight.Children.Add(hpText);

                    foreach (var spell in monsterSpells)
                    {
                        var spellTextBlock = new TextBlock
                        {
                            Text = $"Spell : {spell.Name}, Damage : {spell.Damage}",
                            FontSize = 14,
                            Margin = new Thickness(2),
                            Foreground = Brushes.DarkSlateBlue
                        };
                        stackPanelRight.Children.Add(spellTextBlock);
                    }

                   
                    var playGameButton = new Button
                    {
                        Content = "PLAY GAME",
                        Margin = new Thickness(5),
                        Width = 120,
                        Height = 40,
                        Background = Brushes.Purple,
                        Foreground = Brushes.White,
                        FontWeight = FontWeights.Bold
                    };

                    playGameButton.Click += (sender, e) =>
                    {
                        if (monster != null)
                        {
                            var randomMonster = DataMonster.GetRandomMonster();
                            var fightView = new FightView(monster, randomMonster);
                            fightView.ShowDialog();
                        }
                    };

                    stackPanelRight.Children.Add(playGameButton);
                    RightPanelSpells.Children.Add(stackPanelRight);
                }
            }
            else
            {
                Console.WriteLine("Aucune image trouvée.");
            }
        }
    }
}
