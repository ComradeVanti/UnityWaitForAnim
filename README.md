# WaitForAnim

[![openupm](https://img.shields.io/npm/v/dev.comradevanti.wait-for-anim?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/dev.comradevanti.wait-for-anim/)

A Unity-package for waiting for animations in coroutines.

Check out the wiki [here](https://github.com/ComradeVanti/WaitForAnim/wiki).

Found any issues? Leave
them [here](https://github.com/ComradeVanti/WaitForAnim/issues).

Want to see what's new? The changelog
is [here](https://github.com/ComradeVanti/WaitForAnim/blob/main/CHANGELOG.md).

## Features

Adds custom yield-instructions for waiting for animations to start or finish
inside of coroutines. Example:

```
// using Dev.ComradeVanti.WaitForAnim

yield return new WaitForAnimationToStart(animator, "MyAnim");
```

## Installation

The quickest way is to install via [OpenUPM](https://openupm.com)
using `openupm add dev.comradevanti.wait-for-anim`.

Or install manually
as [git dependency](https://docs.unity3d.com/Manual/upm-ui-giturl.html)
from `https://github.com/ComradeVanti/WaitForAnim.git` or download as zip
and [import locally](https://docs.unity3d.com/Manual/upm-ui-local.html).

## Compatability

Developed with Unity 2020.3 but good chance that it will work with earlier
versions, though this has not been tested.
