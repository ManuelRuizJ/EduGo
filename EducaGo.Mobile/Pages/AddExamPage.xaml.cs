using Microsoft.Maui.Controls;
namespace EducaGo.Mobile.Pages;


public partial class AddExamPage : ContentPage
{
    private RadioButton? _currentlyChecked = null;

    public AddExamPage()
	{
		InitializeComponent();
	}
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value) // Si el RadioButton se acaba de marcar
        {
            if (sender == _currentlyChecked)
            {
                // Si el RadioButton que se marcó es el que ya estaba marcado, desmarcarlo
                ((RadioButton)sender).IsChecked = false;
                _currentlyChecked = null;
            }
            else
            {
                // Si se marcó un nuevo RadioButton, desmarca el que estaba marcado previamente
                if (_currentlyChecked != null)
                {
                    _currentlyChecked.IsChecked = false;
                }
                // Guarda la referencia al RadioButton que se acaba de marcar
                _currentlyChecked = (RadioButton)sender;
            }
        }
        else
        {
            // Si el RadioButton se desmarcó 
            if (sender == _currentlyChecked)
            {
                _currentlyChecked = null;
            }
        }
    }

    private int _questionCounter = 1; // Contador para generar GroupName único

    private void OnAddAnotherQuestionClicked(object sender, EventArgs e)
    {
        // Clonar la plantilla de la pregunta
        if (preguntaContainer.Children.FirstOrDefault() is VerticalStackLayout firstQuestionTemplate)
        {
            var newQuestionLayout = new VerticalStackLayout
            {
                Spacing = 20,
                Children =
                {
                    new Entry { Placeholder = "Escriba aquí su pregunta" },
                    new Label { Text = "Opciones de respuesta", FontSize = 16, FontAttributes = FontAttributes.Bold },
                    new VerticalStackLayout
                    {
                        Spacing = 10,
                        Children =
                        {
                            CreateAnswerOptionEntryWithRadioButton("Escriba la opción 1", $"pregunta{_questionCounter}"),
                            CreateAnswerOptionEntryWithRadioButton("Escriba la opción 2", $"pregunta{_questionCounter}"),
                            CreateAnswerOptionEntryWithRadioButton("Escriba la opción 3", $"pregunta{_questionCounter}"),
                            CreateAnswerOptionEntryWithRadioButton("Escriba la opción 4", $"pregunta{_questionCounter}")
                        }
                    }
                }
            };
            preguntaContainer.Children.Add(newQuestionLayout);
            _questionCounter++; // Incrementa el contador para la siguiente pregunta

        }
    }

    private HorizontalStackLayout CreateAnswerOptionEntryWithRadioButton(string placeholder, string groupName)
    {
        return new HorizontalStackLayout
        {
            Spacing = 10,
            VerticalOptions = LayoutOptions.Center,
            Children =
            {
                new Entry { Placeholder = placeholder, HorizontalOptions = LayoutOptions.Fill },
                new RadioButton { Content = "Seleccione la respuesta correcta", VerticalOptions = LayoutOptions.Center, GroupName = groupName }
            }
        };
    }

    private async void OnCancelAdd(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
    private async void OnAceptAdd(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.CoursesPage());
    }

}