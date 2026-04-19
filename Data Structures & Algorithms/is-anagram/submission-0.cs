public class Solution {
    public bool IsAnagram(string s, string t) {
        return s.ToLower().OrderBy(x => x).SequenceEqual(t.ToLower().OrderBy(x => x));
    }
}
