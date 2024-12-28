using Godot;
using PhantomCamera.Cameras;
using PhantomCamera.Hosts;

namespace PhantomCamera;

public static class PhantomCameraExtension
{
    public static PhantomCamera3D AsPhantomCamera3D(this Node3D node3D) => new(node3D);

    public static PhantomCamera2D AsPhantomCamera2D(this Node2D node2D) => new(node2D);

    public static PhantomCameraHost AsPhantomCameraHost(this Node node) => new(node);

    public static PhantomCameraNoiseEmitter2D AsPhantomCameraNoiseEmitter2D(this Node2D node2D) => new(node2D);
}
