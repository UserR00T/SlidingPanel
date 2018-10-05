# SlidingPanel

> Animate your panel's width and height.

![](https://i.imgur.com/qQR8IKG.gif)

Version: [MP4](https://puu.sh/BGd0U/0526b82275.mp4) | [GIF](https://i.imgur.com/qQR8IKG.gif)

## Installation

1. Goto ``'Releases'``.
2. Download the latest version.
3. Reference the ``.dll`` into your Windows Forms Application project.

## How to use
1. Create a new ``SlidingPanel`` by typing *(Suggested to add to a ``List<SlidingPanel>``)*
```CSharp
new SlidingPanel(Panel, ToSide, maxWidth, minWidth, increaseBy = 1, threadDelay = 10, start = true);
``` 
2. You can use the ``.Hide()``, ``.Show()``, and ``.Toggle()`` methods on the ``SlidingPanel`` instance.

## Example

```CSharp
// ...
using SlidingPanelNS;
// ...
private readonly List<SlidingPanel> slidingPanels = new List<SlidingPanel>();
private void Form1_Load(object sender, EventArgs e)
{
    slidingPanels.Add(new SlidingPanel(SidePanel, SlidingPanel.ToSide.Right, 200, SidePanel.Width, 3));
    slidingPanels.Add(new SlidingPanel(SidePanel2, SlidingPanel.ToSide.Right, 2, SidePanel2.Width, 1, 400));
    slidingPanels.Add(new SlidingPanel(MainPanel, SlidingPanel.ToSide.Bottom, 230, MainPanel.Height, 3));
}
private void CloseBtn_Click(object sender, EventArgs e)
{
    slidingPanels.ForEach(x=>x.Hide());
}
private void OpenBtn_Click(object sender, EventArgs e)
{
    slidingPanels.ForEach(x => x.Show());
}
private void ToggleBtn_Click(object sender, EventArgs e)
{
    slidingPanels.ForEach(x => x.Toggle());
}
```

## Methods

Method | Function
--- | ---
``.Show()`` | Opens the panel till it reached the max width/height.
``.Hide()`` | Closes the panel till it reached the min width/height.
``.Toggle()`` | Closes the panel if its open, otherwise it' open it (exactly what toggle should do, duh)
--- | ---
``.StartLoop()`` | Starts the loop if ``start`` at the construcor has been set to false.
``.StopLoop()`` | Stops the loop; nothing will happen when you call ``Show``, ``Hide``, or ``Toggle`` once disabled.
``.ToggleLoop()`` | Toggles the loop.

## Constructor Arguments

```CSharp
public SlidingPanel(Panel mainPanel, ToSide side, int maxWidth, int minWidth, int increaseBy = 1, int threadDelay = 10, bool start = true)
```

Argument | Type | Default | Function
--- | --- | --- | ---
``Panel`` | ``Panel`` | --- | The panel this instance should work on.
``ToSide`` | ``ToSide`` | --- | The side it should go to.
``maxWidth`` | ``int`` | --- | The panel's maximum size.
``minWidth`` | ``int`` | --- | The panel's minimum size.
``increaseBy`` | ``int`` | ``1`` | Increases the panel's size by that integer each tick (ticks are set by ``threadDelay``)
``threadDelay`` | ``int`` | ``10`` | The delay between ticks in milliseconds. 
``start`` | ``bool`` | ``true`` | Start loop once constructed? Suggested to leave ``true``.
