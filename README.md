# WaitForAnim

[![openupm](https://img.shields.io/npm/v/dev.comradevanti.wait-for-anim?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/dev.comradevanti.wait-for-anim/)

A Unity-package for waiting for animations in coroutines.

Check out the wiki [here](https://github.com/ComradeVanti/UnityWaitForAnim/wiki).

Found any issues? Leave
them [here](https://github.com/ComradeVanti/UnityWaitForAnim/issues).

Want to see what's new? The changelog
is [here](https://github.com/ComradeVanti/UnityWaitForAnim/blob/main/CHANGELOG.md).

## Features

### Start an animation and wait for it to finish

If you want to wait for an animation to stop playing, you can use `WaitForAnimationToFinish`.

```csharp
yield return new WaitForAnimationToFinish(animator, "MyAnim");
```

You can also start an animation and wait for it to finish using the extension method `PlayAndWait`.

```csharp
yield return animator.PlayAndWait("MyAnim");
```

### Wait for an animation to start

If you want to wait for an animation to start playing, you can use `WaitForAnimationToStart`.

```csharp
yield return new WaitForAnimationToStart(animator, "Test");
```

## Installation

The quickest way is to install via [OpenUPM](https://openupm.com)
using `openupm add dev.comradevanti.wait-for-anim`.

Or install manually
as [git dependency](https://docs.unity3d.com/Manual/upm-ui-giturl.html)
from `https://github.com/ComradeVanti/UnityWaitForAnim.git` or download as zip
and [import locally](https://docs.unity3d.com/Manual/upm-ui-local.html).

## Compatability

Developed with Unity 2020.3 but good chance that it will work with earlier
versions, though this has not been tested.
