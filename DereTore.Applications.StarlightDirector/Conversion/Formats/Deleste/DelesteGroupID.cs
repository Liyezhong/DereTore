﻿namespace DereTore.Applications.StarlightDirector.Conversion.Formats.Deleste {
    internal static class DelesteGroupID {

        public static bool IsSupportedGroup(int groupID) {
            var m = groupID % 4;
            return m == 0 || m == 1;
        }

    }
}
