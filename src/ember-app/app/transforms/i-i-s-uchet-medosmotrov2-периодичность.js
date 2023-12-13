import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import ПериодичностьEnum from '../enums/i-i-s-uchet-medosmotrov2-периодичность';

export default FlexberryEnum.extend({
  enum: ПериодичностьEnum,
  sourceType: 'IIS.UchetMedosmotrov2.Периодичность'
});
