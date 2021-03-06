using UnityEditor;
using UnityEngine;

namespace BrunoMikoski.Pooling
{
    [InitializeOnLoad]
    public static class SimplePoolSettingsGenerator
    {
        static SimplePoolSettingsGenerator()
        {
            if (Application.isPlaying)
                return;

            SimplePoolSettings.LoadOrCreateInstance();
        }
    }
}

// Add a comment.
// Add another comment.
// Final comment for testing.
// Add another comment now.
