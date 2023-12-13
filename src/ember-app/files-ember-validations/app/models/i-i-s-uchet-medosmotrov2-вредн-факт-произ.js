import {
  defineNamespace,
  defineProjections,
  Model as ВреднФактПроизMixin
} from '../mixins/regenerated/models/i-i-s-uchet-medosmotrov2-вредн-факт-произ';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ВреднФактПроизMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
