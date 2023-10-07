/**
    Group: Alt-Z
    Authors:
    - Stephen Beckstead
    - Truman Benjamin
    - Ethan Glenn
    - Wessly Green
    - Nii Gogoe
*/

using System;
    public class Entry
    {
        public string _prompt;
        public string _reply;
        public string _date;
        public Entry(string _reply){
            this._reply = _reply;
            DateTime currentDateTime = DateTime.Now;
            this._date = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void setPrompt(string prompt)
        {
            _prompt = prompt;
        }

        public String[] readEntry() {
            return new String[] { _prompt, _reply };
        }
    }
