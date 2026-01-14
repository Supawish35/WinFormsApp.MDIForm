namespace WinFormsApp.MDIForm;

public class ColourChanger {
    // Variable to hold the reference to the "Other Form"
    private Form _targetForm;
    private bool _isLooping;
    private Random _rand;

    // CONSTRUCTOR: We ask for the form when we create this class
    public ColourChanger(Form formToChange)
    {
        _targetForm = formToChange;
        _rand = new Random();
    }

    public async void Start()
    {
        if (_isLooping) return; // Don't start twice
        _isLooping = true;

        while (_isLooping)
        {
            // 1. Pick a random color
            Color newColor = Color.FromArgb(_rand.Next(256), _rand.Next(256), _rand.Next(256));

            // 2. Change the color of the OTHER form safely
            SetFormColor(newColor);

            // 3. Wait
            await Task.Delay(10);
        }
    }

    public void Stop()
    {
        _isLooping = false;
    }

    // Helper to safely update UI from any thread
    private void SetFormColor(Color color)
    {
        // If the form is closed or disposed, stop trying to change it
        if (_targetForm.IsDisposed) 
        {
            _isLooping = false; 
            return;
        }

        if (_targetForm.InvokeRequired)
        {
            _targetForm.Invoke(new Action(() => _targetForm.BackColor = color));
        }
        else
        {
            _targetForm.BackColor = color;
        }
    }
}