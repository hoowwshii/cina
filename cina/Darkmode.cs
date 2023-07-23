using System.Drawing;
using System.Windows.Forms;

public static class DarkMode
{
    // Define your dark mode colors here.
    private static Color darkBackColor = Color.FromArgb(30, 30, 30);
    private static Color darkForeColor = Color.White;
    private static Color darkControlBackColor = Color.FromArgb(40, 40, 40);
    private static Color darkControlForeColor = Color.White;

    public static void ApplyDarkMode(Form form)
    {
        // Set dark mode colors for the form.
        form.BackColor = darkBackColor;
        form.ForeColor = darkForeColor;

        // Apply dark mode to all controls on the form.
        ApplyDarkModeToControls(form);
    }

    private static void ApplyDarkModeToControls(Control control)
    {
        control.BackColor = darkControlBackColor;
        control.ForeColor = darkControlForeColor;

        // Recursively apply dark mode to all child controls.
        foreach (Control childControl in control.Controls)
        {
            ApplyDarkModeToControls(childControl);
        }
    }
}
