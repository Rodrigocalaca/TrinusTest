using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TrinusTest.Models.People;

namespace TrinusTest.Controls
{
    /// <summary>
    /// Siga os passos 1a ou 1b e depois 2 para usar esse controle personalizado em um arquivo XAML.
    ///
    /// Passo 1a) Usando o controle personalizado em um arquivo XAML que já existe no projeto atual.
    /// Adicione o atributo XmlNamespace ao elemento raiz do arquivo de marcação onde ele 
    /// deve ser usado:
    ///
    ///     xmlns:MyNamespace="clr-namespace:TrinusTest.Controls"
    ///
    ///
    /// Passo 1b) Usando o controle personalizado em um arquivo XAML que existe em um projeto diferente.
    /// Adicione o atributo XmlNamespace ao elemento raiz do arquivo de marcação onde ele 
    /// deve ser usado:
    ///
    ///     xmlns:MyNamespace="clr-namespace:TrinusTest.Controls;assembly=TrinusTest.Controls"
    ///
    /// Também será necessário adicionar nesse projeto uma referência ao projeto que contém esse arquivo XAML
    /// e Recompilar para evitar erros de compilação:
    ///
    ///     No Gerenciador de Soluções, clique com o botão direito no projeto alvo e
    ///     "Add Reference"->"Projects"->[Procure e selecione o projeto]
    ///
    ///
    /// Passo 2)
    /// Vá em frente e use seu controle no arquivo XAML.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    [TemplatePart(Name = "textblockBadge", Type = typeof(TextBlock))]
    [TemplatePart(Name = "deleteButton", Type = typeof(Button))]
    public class UserCard : Control
    {
        private TextBlock? textblockBadge;

        private Button? deleteButton;

        static UserCard()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UserCard), new FrameworkPropertyMetadata(typeof(UserCard)));
        }

        public override void OnApplyTemplate()
        {
            if (deleteButton != null)
            {
                deleteButton.Click -= DeleteButton_Click;
            }


            var result = GetTemplateChild(nameof(textblockBadge));
            var button = GetTemplateChild(nameof(deleteButton));

            if(button != null)
            {
                deleteButton = button as Button;
                deleteButton!.Click += DeleteButton_Click;
            }

            if (result is not null && textblockBadge is null)
            {
                textblockBadge = result as TextBlock;
                if (textblockBadge != null)
                {
                    if (AgeBadge != null && AgeBadge == AgeIndentifier.CHILD)
                    {
                        textblockBadge!.Text = "CRIANÇA";
                    }
                    else if (AgeBadge != null && AgeBadge == AgeIndentifier.YOUNG)
                    {
                        textblockBadge!.Text = "JOVEM";
                    }
                    else if (AgeBadge != null && AgeBadge == AgeIndentifier.ADULT)
                    {
                        textblockBadge!.Text = "ADULTO";
                    }
                    else
                    {
                        textblockBadge!.Text = "IDOSO";
                    }
                }
            }
            base.OnApplyTemplate();
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(300);
            DeleteCommand?.Execute(DeleteCommandParameter);
        }

        public string UserName
        {
            get { return (string)GetValue(UserNameProperty); }
            set { SetValue(UserNameProperty, value); }
        }

        public static readonly DependencyProperty UserNameProperty =
            DependencyProperty.Register(nameof(UserName), typeof(string), typeof(UserCard), new PropertyMetadata(string.Empty));


        public string UserAge
        {
            get { return (string)GetValue(UserAgeProperty); }
            set { SetValue(UserAgeProperty, value); }
        }

        public static readonly DependencyProperty UserAgeProperty =
            DependencyProperty.Register(nameof(UserAge), typeof(string), typeof(UserCard), new PropertyMetadata(string.Empty));


        public string UserSsn
        {
            get { return (string)GetValue(UserSsnProperty); }
            set { SetValue(UserSsnProperty, value); }
        }

        public static readonly DependencyProperty UserSsnProperty =
            DependencyProperty.Register(nameof(UserSsn), typeof(string), typeof(UserCard), new PropertyMetadata(string.Empty));


        public ICommand EditCommand
        {
            get { return (ICommand)GetValue(EditCommandProperty); }
            set { SetValue(EditCommandProperty, value); }
        }

        public static readonly DependencyProperty EditCommandProperty =
            DependencyProperty.Register(nameof(EditCommand), typeof(ICommand), typeof(UserCard), new PropertyMetadata(null));

        public ICommand DeleteCommand
        {
            get { return (ICommand)GetValue(DeleteCommandProperty); }
            set { SetValue(DeleteCommandProperty, value); }
        }

        public static readonly DependencyProperty DeleteCommandProperty =
            DependencyProperty.Register(nameof(DeleteCommand), typeof(ICommand), typeof(UserCard), new PropertyMetadata(null));


        public object EditCommandParameter
        {
            get { return (object)GetValue(EditCommandParameterProperty); }
            set { SetValue(EditCommandParameterProperty, value); }
        }

        public static readonly DependencyProperty EditCommandParameterProperty =
            DependencyProperty.Register(nameof(EditCommandParameter), typeof(object), typeof(UserCard), new PropertyMetadata(null));


        public object DeleteCommandParameter
        {
            get { return (object)GetValue(DeleteCommandParameterProperty); }
            set { SetValue(DeleteCommandParameterProperty, value); }
        }

        public static readonly DependencyProperty DeleteCommandParameterProperty =
            DependencyProperty.Register(nameof(DeleteCommandParameter), typeof(object), typeof(UserCard), new PropertyMetadata(null));


        public AgeIndentifier? AgeBadge
        {
            get { return (AgeIndentifier?)GetValue(AgeBadgeProperty); }
            set { SetValue(AgeBadgeProperty, value); }
        }

        public static readonly DependencyProperty AgeBadgeProperty =
            DependencyProperty.Register(nameof(AgeBadge), typeof(AgeIndentifier?), typeof(UserCard), new PropertyMetadata(null, new PropertyChangedCallback(PropertyChangedCallback)));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UserCard userCard && userCard != null)
            {
                if (userCard.textblockBadge == null)
                {
                    var result = userCard.GetTemplateChild(nameof(textblockBadge));
                    if (result is not null)
                    {
                        userCard.textblockBadge = result as TextBlock;
                    }
                }

                if (userCard.textblockBadge != null)
                {
                    if (e.NewValue != null && (e.NewValue as AgeIndentifier?) == AgeIndentifier.CHILD)
                    {
                        userCard.textblockBadge!.Text = "CRIANÇA";
                    }
                    else if (e.NewValue != null && (e.NewValue as AgeIndentifier?) == AgeIndentifier.YOUNG)
                    {
                        userCard.textblockBadge!.Text = "JOVEM";
                    }
                    else if (e.NewValue != null && (e.NewValue as AgeIndentifier?) == AgeIndentifier.ADULT)
                    {
                        userCard.textblockBadge!.Text = "ADULTO";
                    }
                    else
                    {
                        userCard.textblockBadge!.Text = "IDOSO";
                    }
                }
            }
        }

    }
}
