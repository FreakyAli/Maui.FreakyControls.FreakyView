using System;
namespace Maui.FreakyControls;

public partial class FreakyViewHandler
{
    private static int blurProcessingDelayMilliseconds = 10;

    public static int BlurProcessingDelayMilliseconds
    {
        get => blurProcessingDelayMilliseconds;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    "The blur processing delay cannot be negative",
                    nameof(BlurProcessingDelayMilliseconds));
            }

            blurProcessingDelayMilliseconds = value;
        }
    }
}