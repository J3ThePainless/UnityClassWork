﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public interface IDroppable
{

    bool CanDrop();

    void OnDrop();

}