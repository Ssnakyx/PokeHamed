using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using WpfApp1.MVVM.Model;
using WpfApp1.MVVM.ViewModel;

namespace WpfApp1.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour SpellsView.xaml
    /// </summary>
    public partial class SpellsView : UserControl
    {
        public SpellsView()
        {
            InitializeComponent();
            LoadSpell();
        }

        private void LoadSpell()
        {
            var spells = DataSpell.DisplaySpell();
            if (spells != null && spells.Any())
            {
                foreach (var spell in spells)
                {
                  
                    var border = new Border
                    {
                        BorderBrush = Brushes.Gray,
                        BorderThickness = new Thickness(1),
                        CornerRadius = new CornerRadius(5), 
                        Margin = new Thickness(5),
                        Padding = new Thickness(5),
                        Background = Brushes.LightGray
                    };

                    var spellPanel = new StackPanel
                    {
                        Orientation = Orientation.Vertical,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center
                    };

                  
                    var nameTextBlock = new TextBlock
                    {
                        Text = spell.Name,
                        FontSize = 12,
                        FontWeight = FontWeights.Bold,
                        Margin = new Thickness(0, 5, 0, 5),
                        TextAlignment = TextAlignment.Center,
                        Foreground = Brushes.DarkSlateBlue
                    };
                    spellPanel.Children.Add(nameTextBlock);

                    
                    var damageTextBlock = new TextBlock
                    {
                        Text = $"Dégâts : {spell.Damage}",
                        FontSize = 10,
                        Margin = new Thickness(0, 0, 0, 5),
                        TextAlignment = TextAlignment.Center
                    };
                    spellPanel.Children.Add(damageTextBlock);

                   
                    var descriptionTextBlock = new TextBlock
                    {
                        Text = spell.Description,
                        FontSize = 10,
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 5),
                        TextAlignment = TextAlignment.Center
                    };
                    spellPanel.Children.Add(descriptionTextBlock);

                    border.Child = spellPanel;

                    SpellsWrapPanel.Children.Add(border);
                }
            }
            else
            {
               
                var noSpellsTextBlock = new TextBlock
                {
                    Text = "Aucun sort disponible.",
                    FontSize = 12,
                    FontWeight = FontWeights.Bold,
                    TextAlignment = TextAlignment.Center,
                    Margin = new Thickness(10),
                    Foreground = Brushes.Gray
                };
                SpellsWrapPanel.Children.Add(noSpellsTextBlock);
            }
        }
    }
}
