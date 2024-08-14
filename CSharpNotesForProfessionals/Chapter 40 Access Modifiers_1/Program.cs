
using Chapter_40_Access_Modifiers_protected_internal;

Console.WriteLine("");
public class Baz : Foo
{
    void Mymethod1()
    {
        var myPublicProperty = MyPublicProperty;
        var myprotectedInternalproperty = MyprotectedInternalProperty;
        var thing = new MyprotectedInternalNestedClass();
    }

    void MyMethod2()
    {
        Foo foo = new Foo();
        var myPublicProperty = foo.MyPublicProperty;

   //     var myProtectedInternalProperty = foo.MyprotectedInternalProperty;

    //    var myProtectedInternalNestedIntance = new Foo().MyprotectedInternalNestedClass();
    }

}


public class Qux
{
    void MyMethod1()
    {
        Baz baz = new Baz();

        var mypublicproperty = baz.MyPublicProperty;
    //    var myPublicProtectedInternalproperty = baz.MyprotectedInternalProperty;


      //  var myProtedtedInternalProperty = Foo.MyprotectedInternalProperty;
     //   var myProtectedInternalNestedIntance = new Foo().MyprotectedInternalNestedClass();

    }

    void MyMethod2()
    {
        Foo foo = new Foo();

        var myPublicProperty = foo.MyPublicProperty;

    //    var myProtectedInternalproperty = foo.MyProtectedInternalProperty;

    //    var myprotectedInternalNestedClass = new Foo.MyProtectedInternalNestedClass();
    }

}
