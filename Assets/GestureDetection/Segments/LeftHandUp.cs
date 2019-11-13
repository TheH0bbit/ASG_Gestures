using UnityEngine;
using Windows.Kinect;

/// <summary>
/// The first part of the swipe left gesture
/// </summary>
public class LeftHandUpSegment1 : IRelativeGestureSegment
{
    /// <summary>
    /// Checks the gesture.
    /// </summary>
    /// <param name="skeleton">The skeleton.</param>
    /// <returns>GesturePartResult based on if the gesture part has been completed</returns>
    public GesturePartResult CheckGesture(BasicAvatarModel skeleton)
    {
        //handleft below hips, hips below shoulder
        Vector3 handLeft = skeleton.getRawWorldPosition(JointType.HandLeft);
        Vector3 shoulderCenter = skeleton.getRawWorldPosition(JointType.SpineShoulder);
        Vector3 HipLeft = skeleton.getRawWorldPosition(JointType.HipLeft);

        if (handLeft.x < shoulderCenter.x && HipLeft.y < shoulderCenter.y)
        {
            //handleft below hips, hips below shoulder

            if (handLeft.y < HipLeft.y && HipLeft.y < shoulderCenter.y)
            {
                //Debug.Log("Segment1 Success");
                return GesturePartResult.Succeed;
                
            }
            return GesturePartResult.Pausing;
        }
        return GesturePartResult.Fail;
    }
}

/// <summary>
/// The second part of the swipe left gesture
/// </summary>
public class LeftHandUpSegment2 : IRelativeGestureSegment
{
    /// <summary>
    /// Checks the gesture.
    /// </summary>
    /// <param name="skeleton">The skeleton.</param>
    /// <returns>GesturePartResult based on if the gesture part has been completed</returns>
    public GesturePartResult CheckGesture(BasicAvatarModel skeleton)
    {
        //handleft below hips, hips below shoulder
        Vector3 handLeft = skeleton.getRawWorldPosition(JointType.HandLeft);
        Vector3 shoulderCenter = skeleton.getRawWorldPosition(JointType.SpineShoulder);
        Vector3 HipLeft = skeleton.getRawWorldPosition(JointType.HipLeft);

        if (handLeft.x < shoulderCenter.x && HipLeft.y < shoulderCenter.y)
        {
            //handleft below hips, hips below shoulder

            if (handLeft.y > HipLeft.y && handLeft.y < shoulderCenter.y)
            {
                //Debug.Log("Segment2 Success");
                return GesturePartResult.Succeed;

            }
            return GesturePartResult.Pausing;
        }
        return GesturePartResult.Fail;
    }
}

/// <summary>
/// The third part of the swipe left gesture
/// </summary>
public class LeftHandUpSegment3 : IRelativeGestureSegment
{
    /// <summary>
    /// Checks the gesture.
    /// </summary>
    /// <param name="skeleton">The skeleton.</param>
    /// <returns>GesturePartResult based on if the gesture part has been completed</returns>
    public GesturePartResult CheckGesture(BasicAvatarModel skeleton)
    {
        //handleft below hips, hips below shoulder
        Vector3 handLeft = skeleton.getRawWorldPosition(JointType.HandLeft);
        Vector3 shoulderCenter = skeleton.getRawWorldPosition(JointType.SpineShoulder);
        Vector3 HipLeft = skeleton.getRawWorldPosition(JointType.HipLeft);

        if (handLeft.x < shoulderCenter.x && HipLeft.y < shoulderCenter.y)
        {
            //handleft below hips, hips below shoulder

            if (handLeft.y > HipLeft.y && handLeft.y > shoulderCenter.y)
            {
                //Debug.Log("Segment2 Success");
                return GesturePartResult.Succeed;

            }
            return GesturePartResult.Pausing;
        }
        return GesturePartResult.Fail;
    }
}