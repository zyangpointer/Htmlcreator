var SomeModel = Backbone.Model.extend({});

someModel = new SomeModel();

someModel.bind("change", function (model, collection) {
    alert("You set some_attribute to " + model.get('some_attribute'));
});

someModel.set({ some_attribute: "some value" });