﻿
#region

public enum PLAYER_NUMBER
{
    NONE,
    PLAYER_1,
    PLAYER_2,
    PLAYER_3,
    PLAYER_4,
}

public enum PLAYER_COLOR
{
    NONE,
    RED,
    BLUE,
    GREEN,
    YELLOW,
}

public enum PLAYER_STATE
{
    NONE,
    STAND,
    IN_COVER,
    IS_VAULTING
}


public enum DIRECTION
{
    NONE,
    LEFT,
    RIGHT,
    UP,
    DOWN
}

public enum AXIS
{
    NONE,
    X,
    Y,
    Z
}

#endregion

#region CAMERA

public enum CAMERA_STATE
{
    NONE,
    FOLLOWING_PLAYER,
    IN_COVER,
    IN_CONVERSATION
}


public enum CAMERA_FADE_TYPE
{
    NONE,
    IN,
    OUT,
    FADE_OUT_THEN_IN,
    FADE_IN_THEN_OUT
}

public enum CONVERSATION_CAMERA_ACTION
{
    NONE,
    DIRECT,
    ROTATE,
    MOVETO,
    MOVE_AND_ROTATE
}

public enum CONVERSATION_CAMERA_MOVETYPE
{
    NONE,
    LERP,
    SLERP
}

#endregion

#region INTERACTION

public enum INTERACTABLE_OBJECT_TYPE
{
    NONE,
    PHYSICS,
    ACTOR
}

#endregion

#region SATELLITE

public enum SATELLITE_COMMAND_TYPE
{
    NONE,
    MOVE,
    ROTATE
}

#endregion

#region PLAYER_CAMERA

public enum PLAYER_CAMERA_STATE
{
    NONE,
    MAIN_SCREEN,
    ZOOM_OUT,
    RADAR
}

#endregion

