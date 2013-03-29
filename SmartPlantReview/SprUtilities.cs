﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace SharpPlant.SmartPlantReview
{
    public static class SprUtilities
    {
        public static Dictionary<string, object> TagTemplate = new Dictionary<string, object>
            {
                {"tag_unique", 0},
                {"target_x", 0},
                {"target_y", 0},
                {"target_z", 0},
                {"clip_far", 0},
                {"clip_near", 0},
                {"perspective", 0},
                {"persp_ang", 0},
                {"ortho", false},
                {"eye_x", 0},
                {"eye_y", 0},
                {"eye_z", 0},
                {"up_x", 0},
                {"up_y", 0},
                {"up_z", 0},
                {"tag_deleted", false},
                {"tag_size", 0},
                {"tag_origin_x", 0},
                {"tag_origin_y", 0},
                {"tag_origin_z", 0},
                {"tag_point_x", 0},
                {"tag_point_y", 0},
                {"tag_point_z", 0},
                {"linkage_id_0", 0},
                {"linkage_id_1", 0},
                {"linkage_id_2", 0},
                {"linkage_id_3", 0},
                {"tag_text", string.Empty},
                {"tag_comment", string.Empty},
                {"record_origin", string.Empty},
                {"record_modified", string.Empty},
                {"date_placed", string.Empty},
                {"last_edited", string.Empty},
                {"number_color", 0},
                {"backgnd_color", 0},
                {"leader_color", 0},
                {"discipline", string.Empty},
                {"category", string.Empty},
                {"creator", string.Empty},
                {"site_id", string.Empty},
                {"computer_name", string.Empty},
                {"status", string.Empty}
            };

        /// <summary>
        ///     Returns a 24-bit color integer.
        /// </summary>
        /// <param name="rgbColor">The System.Drawing.Color to be converted.</param>
        /// <returns></returns>
        public static int Get0Bgr(Color rgbColor)
        {
            // Return a zero-alpha 24-bit BGR color integer
            return 0 + (rgbColor.B << 0x10) + (rgbColor.G << 0x8) + rgbColor.R;
        }

        /// <summary>
        ///     Returns a fully opaque (Alpha 255) color from a 0BGR format.
        /// </summary>
        /// <param name="bgrColor">The 0BGR integer to be converted.</param>
        /// <returns></returns>
        public static Color From0Bgr(int bgrColor)
        {
            // Get the color bytes
            var bytes = BitConverter.GetBytes(bgrColor);

            // Return the color from the byte array
            return Color.FromArgb(bytes[0], bytes[1], bytes[2]);
        }
    }
}