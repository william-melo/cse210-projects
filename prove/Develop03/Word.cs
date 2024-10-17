using System;
class Word
{
  private string _text;
  private bool _isHidden = false;

  public Word(string text)
  {
    _text = text;
  }

  public string Text 
    {
        get { return _text; }
        set { _text = value; }
    }

  public bool IsHidden
    {
        get { return _isHidden; }
        set { _isHidden = value; }
    }


  public void Hide()
  {
    _isHidden = true;
  }

  public void Show()
  {
    _isHidden = false;
  }


  public string GetDisplayText()
  {
    if (_isHidden == true)
    {
      string replaced = new string('_', _text.Length);
      return replaced;
    }
    else
    {
      return _text;
    }
  }
}